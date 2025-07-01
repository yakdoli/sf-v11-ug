Imports Microsoft.VisualBasic
Imports System
Namespace Word2007Demo_2005
	Partial Public Class Form1
				''' <summary>
				''' Required designer variable.
				''' </summary>
				Private components As System.ComponentModel.IContainer = Nothing

				''' <summary>
				''' Clean up any resources being used.
				''' </summary>
				''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
				Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
						If disposing AndAlso (Not components Is Nothing) Then
								components.Dispose()
						End If
						MyBase.Dispose(disposing)
				End Sub

				#Region "Windows Form Designer generated code"

				''' <summary>
				''' Required method for Designer support - do not modify
				''' the contents of this method with the code editor.
				''' </summary>
				Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim ToolTipInfo6 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolStripTabGroup1 As Syncfusion.Windows.Forms.Tools.ToolStripTabGroup = New Syncfusion.Windows.Forms.Tools.ToolStripTabGroup
            Dim ToolStripTabGroup2 As Syncfusion.Windows.Forms.Tools.ToolStripTabGroup = New Syncfusion.Windows.Forms.Tools.ToolStripTabGroup
            Dim ToolTipInfo41 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo42 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo43 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo44 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo45 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo58 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo46 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo47 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo48 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo49 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo50 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo51 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo52 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo53 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo54 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo55 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo56 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo57 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo59 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo60 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo61 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo62 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo63 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo64 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo65 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo66 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo67 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo68 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo69 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo70 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo71 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolStripGalleryItem1 As Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem = New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem
            Dim ToolStripGalleryItem2 As Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem = New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem
            Dim ToolStripGalleryItem3 As Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem = New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem
            Dim ToolStripGalleryItem4 As Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem = New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem
            Dim ToolStripGalleryItem5 As Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem = New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem
            Dim ToolStripGalleryItem6 As Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem = New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem
            Dim ToolStripGalleryItem7 As Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem = New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem
            Dim ToolStripGalleryItem8 As Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem = New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem
            Dim ToolStripGalleryItem9 As Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem = New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem
            Dim ToolTipInfo72 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo73 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo74 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo75 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo76 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo77 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo78 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo79 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo80 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo81 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo82 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo83 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo84 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo85 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo86 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo87 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo88 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo89 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo90 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo91 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo92 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo93 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo94 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo95 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo96 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo97 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo98 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo106 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo99 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo100 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo101 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo102 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo103 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo104 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo105 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo107 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo108 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo109 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo114 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo110 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo111 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo112 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo113 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo115 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo116 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo117 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo118 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo119 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo120 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo121 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo122 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo123 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo124 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo129 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo125 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo126 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo127 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo128 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo130 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo131 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo132 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo133 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo134 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo135 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo136 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo137 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo138 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo139 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo140 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo141 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo142 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo143 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo144 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo145 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo146 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo147 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo148 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo149 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo150 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo151 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo152 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo153 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo154 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo155 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo156 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo157 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo158 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo159 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo160 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo161 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo162 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo163 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo164 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo165 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo166 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo167 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo168 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo169 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo170 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo171 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo172 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo173 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo174 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo175 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo176 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo177 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo178 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo179 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo180 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo181 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo182 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo183 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo184 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo185 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo186 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo187 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo188 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo189 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo190 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo191 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo192 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo193 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo194 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo195 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo196 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo197 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo198 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo199 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo200 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo201 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo202 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo7 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo8 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo9 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo10 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo11 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo12 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo18 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo13 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo14 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo15 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo16 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo17 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo22 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo19 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo20 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo21 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo30 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo23 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo24 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo25 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo26 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo27 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo28 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo29 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo33 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo31 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo32 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo37 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo34 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo35 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo36 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo38 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo39 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo40 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo203 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo204 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo205 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo206 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo207 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo208 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo209 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo210 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo4 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo5 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim ToolTipInfo1 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo2 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo3 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Me.ribbonControlAdv1 = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv
            Me.homeTabItem = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem
            Me.clipboardToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem15 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripBtnPaste = New System.Windows.Forms.ToolStripButton
            Me.toolStripDropDownBtnPaste = New System.Windows.Forms.ToolStripDropDownButton
            Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pasteSpecialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pasteAsHyperlinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripBtnCut = New System.Windows.Forms.ToolStripButton
            Me.toolStripBtnCopy = New System.Windows.Forms.ToolStripButton
            Me.toolStripBtnPaint = New System.Windows.Forms.ToolStripButton
            Me.fontToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripFontfaceComboBox = New System.Windows.Forms.ToolStripComboBox
            Me.toolStripFontSizeComboBox = New System.Windows.Forms.ToolStripComboBox
            Me.toolStripPanelItem3 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.growfontToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.shrinkfontToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem48 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.clearToolstripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem4 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.boldToolstripBtn = New System.Windows.Forms.ToolStripButton
            Me.italicToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.underlineToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.moreUnderlinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.underlineColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.automaticToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.moreColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.strikethroToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem5 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.subscriptToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.superscriptToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem47 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.changecaseToolStripBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripPanelItem6 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.txthighltToolStripsplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.noColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
            Me.stopHighlightingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.fontcolorToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.automaticToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.themeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.moreColorsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.paragraphToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem7 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.bulletToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.changeListLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.defineNewBulletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.numberingToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.changeListLevelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.defineNewNumberFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.setNumberingValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.multilevelToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.changeListLevelToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
            Me.defineNewMultilevelListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.defineNewListStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem8 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.deindentToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.inindentToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem9 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.sortToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.lAlignToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.centerToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.rAlignToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.justifyToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.lspacingToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
            Me.moreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
            Me.addSpaceBeforeParagraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.removeSpaceAfterParagraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.shadingToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.noColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
            Me.moreShadingColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.btmborderToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.bottomBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.topBoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.leftBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.rightBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
            Me.noBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.allBordersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.outsideBordersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.insideBordersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
            Me.insideHorizontalBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.insideVerticalBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.diagonalDownBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.diagonalUpBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
            Me.horizontalLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
            Me.showGridlinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.bordersAndShadingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.stylesToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripGallery2 = New Syncfusion.Windows.Forms.Tools.ToolStripGallery
            Me.GalleryImages = New System.Windows.Forms.ImageList(Me.components)
            Me.qckstylesToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.blueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.silverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.blackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.editingToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem10 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.findToolStripBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.findToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.goToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.replaceToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.selectToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.selectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.selectObjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.selectTextWithSimilarFormattingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.insertTabItem = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem
            Me.pagesToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.coverPageToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.formatPageNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.removeCurrentCoverPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveSelectionToCoverPageGalleryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.blankPageToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.pageBreakToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.tablesToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.tableToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.insertTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.drawTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.convertTextToTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.excelSpreadsheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.quickTablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveSelectionToQuickTablToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.linksToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.hyperlinkToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.bookmarkToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.crossrefToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.headerToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.headerToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.editHeaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.removeHeaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveSelectionToHeaderGalleryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.footerToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.editFooterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.removeFooterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveSelectionToFooterGalleryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pagenoToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.topOfPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.headerFooterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveSelectionAsPageNumberTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.bottomOfPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.headerFooterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.saveSelectionAsPageNumberBottomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pageMarginsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.sAveSelectionAsPageMarginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.formatPageNumbersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.removePageNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.textToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.txtboxToolStripSplitBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.drawTextBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveSelectionToTextBoxGalleryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem11 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.qckPartsToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.propertyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.abstractToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.authorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.categoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.commentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.companyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.companyAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.companyEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.companyFaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.companyPhoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.keywordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.managerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.publishDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.statusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.subjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.titleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.fieldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pageNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveSelectionToPageNumberGalleryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator
            Me.buildingBlocksOrganizerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.getMoreOnOfficeOnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveSelectionToQuickPartGalleryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.wordArtToolStripSplitBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.dropCapToolStripSplitBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.advancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem12 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.signLineToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.microsoftOfficeSignatureLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator
            Me.addSignatureServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.dateTimeToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.objectToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.textFromFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.objectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.symbolsToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.equationToolStripDropDwnBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.insertNewEquationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveSelectionToEquationGalleryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.symbolToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.moreSymbolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pageLayoutTabItem = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem
            Me.themesToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.themesToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.resetToThemeFromTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.searchOfficeOnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.browseForThemesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveCurrentThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem13 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.themeColorToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.createNewThemeColorsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.themeFontToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.createNewThemeFontsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.themeEffectsToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.pageSetupToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.marginToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.customMarginsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem44 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.orientationToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.sizeToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.morePaperSizesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.columnsToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.moreColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem14 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.breaksToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.lnumbersToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.noneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.continuousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.restartEachPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.restartEachSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.suppressForCurrentSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
            Me.moreLineNumberingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.hyphenationToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.noneToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.automaticToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
            Me.manualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
            Me.hyphenationOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pageBackgroundToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.watermarkToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.moreWatermarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.removeWatermartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveSelectionToWatermarkGalleryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pageColorToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.noColorToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator
            Me.moreColorsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
            Me.fillEffectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pageBordersToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.paraToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem17 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.indentToolStripLabel = New System.Windows.Forms.ToolStripLabel
            Me.toolStripPanelItem19 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.lindentToolStripLabel = New System.Windows.Forms.ToolStripLabel
            Me.ToolStriplindentComboBox = New System.Windows.Forms.ToolStripComboBox
            Me.toolStripPanelItem20 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.rindentToolStripLabel = New System.Windows.Forms.ToolStripLabel
            Me.ToolStriprindentComboBox = New System.Windows.Forms.ToolStripComboBox
            Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripPanelItem18 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.spacingToolStripLabel = New System.Windows.Forms.ToolStripLabel
            Me.toolStripPanelItem21 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.sbeforeToolStripLabel = New System.Windows.Forms.ToolStripLabel
            Me.ToolStripsbeforeComboBox = New System.Windows.Forms.ToolStripComboBox
            Me.toolStripPanelItem22 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.safterToolStripLabel = New System.Windows.Forms.ToolStripLabel
            Me.ToolStripsafterComboBox = New System.Windows.Forms.ToolStripComboBox
            Me.arrangeToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.positionToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripPanelItem23 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.bringToFrontToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.sendToBackToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.txtwrapToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.toolStripPanelItem24 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.alignToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.alignLeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.alignCenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.alignRightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator
            Me.alignTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.alignMiddleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.alignBottomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator
            Me.distributreHorizontallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.distributeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator
            Me.alignToPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.alToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.alignSelectedObjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator
            Me.showGridlinesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.gridSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.groupToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.rotateToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.referencesTabItem = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem
            Me.tbofContentsToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem25 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.tablefcontToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.insertTableOfContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.removeTableOfContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem
            Me.addtxtToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.doNotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.level1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.level2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.level3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.updateTableToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.footNotesToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.inftnoteToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem26 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.inendnoteToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.nxtftnoteToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton
            Me.nextFootnoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.previousFootnoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.nextEndnoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.prevToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.shNotesToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.citationsToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.inCaptionToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.addNewSourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.addNewPlaceholderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.searchLibrariesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem27 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.mgeSourcesToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem28 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.styleToolStripLabel = New System.Windows.Forms.ToolStripLabel
            Me.ToolStripStyleComboBox = New System.Windows.Forms.ToolStripComboBox
            Me.bibliographyToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.insertBibliographyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveSelectionToBibliographyGalleryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveAsNewBibliographyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.captionsToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.inCaptionToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem29 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.inTbofFiguresToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.upTableToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.crrefToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.indexToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem30 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.markEntryToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.inIndexToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.uIndexToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.tbofAuthoritiesToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem31 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.markCitationToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.inTbofAuthoritiesToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.uTableToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.mailingsTabItem = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem
            Me.createToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.envelopeToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.labelsToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.stMailMergeToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.stMailMergeToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.lettersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.emailMessagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.envelopesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.lablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.directoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator
            Me.normalWordDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator
            Me.stepByStepMailMergeWizardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.sltRecipientsToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.typeNewListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.useExistingListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.selectFromOutlookContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.editRecepientsToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.insertFieldsToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.highltMergeToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.addBlockToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.greetingToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.inMergeFieldToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.toolStripPanelItem32 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.rulesToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.matchFieldsToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.upLablesToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.previewResultsToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.previewResultsToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripPanelItem33 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripPanelItem34 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.firstToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.previousToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.recordToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
            Me.nxtToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.lstToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.fndRecepientToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.checkErrorToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.finishToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.finshMergeToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.reviewTabItem = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem
            Me.proofingToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.spellToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem35 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.researchToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.thesaurusToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.translateToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem36 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.translateTooltipToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.englishUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem
            Me.spanishInternationalSortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.turnOffTranslationToolTipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.turnOffTranslationTooltipToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.setLangToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.wordCntToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.commentsToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.nwCommentToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem37 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.delToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.deleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.deleteAllCommentsShownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.deleteAllCommentsInDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.preToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.nxttToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.trackingToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.trkChangesToolStripSplitButton = New System.Windows.Forms.ToolStripSplitButton
            Me.trackChangesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.changeTrackingOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.changeUserNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.balloonsToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.showRevisionsInballoonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.showAllRevisionsInlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.showOnlycommentsAndFormattingInBallonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem38 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripReviewComboBox = New System.Windows.Forms.ToolStripComboBox
            Me.shMarkUpToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.commentsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.inkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.insertionsAndDeletionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.formattingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.markupAreaHighlightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.revieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.allReviewersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.reviewPaneToolStripSplitButton = New System.Windows.Forms.ToolStripSplitButton
            Me.reviewingPaneVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.reviewingPaneHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.changesToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.acceptToolStripSplitButton = New System.Windows.Forms.ToolStripSplitButton
            Me.acceptAndMoveToNextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.acceptChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.acceptAllChangesShownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.acceptAllChangesInDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripPanelItem39 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.rejectToolStripSplitButton = New System.Windows.Forms.ToolStripSplitButton
            Me.rEjectAndMoveToNextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.rejectChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.rejectAllChangesShownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.rejectAllChangesInDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.prevToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.nextToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.compareToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.compareToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.shSrcDocToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.hideSourceDocumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.showOriginalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.showRevisedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.showBothToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripEx6 = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.protectDocToolStripDropDownBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.restrictFormattingAndEditingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.unrestrictedAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.restrictedAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator26 = New System.Windows.Forms.ToolStripSeparator
            Me.manageCredentionalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.viewTabItem = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem
            Me.docViewsToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.printLayoutToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.fullScrToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem46 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.webLayoutToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.outlineToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.draftToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.showToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem40 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.rulerCheckBox = New Syncfusion.Windows.Forms.Tools.ToolStripCheckBox
            Me.gridlinesCheckBox2 = New Syncfusion.Windows.Forms.Tools.ToolStripCheckBox
            Me.msgBarCheckBox = New Syncfusion.Windows.Forms.Tools.ToolStripCheckBox
            Me.toolStripPanelItem41 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.docMapCheckBox = New Syncfusion.Windows.Forms.Tools.ToolStripCheckBox
            Me.thumbNailsCheckBox = New Syncfusion.Windows.Forms.Tools.ToolStripCheckBox
            Me.zoomToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.zoomToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem42 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.onePgToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.twoPgsToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.pgWidthToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.windowToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.toolStripPanelItem45 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.nwWindowToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.arrangeAllToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.splitToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripPanelItem43 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.viewToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.syncScrollToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.resetWindowPosToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator24 = New System.Windows.Forms.ToolStripSeparator
            Me.switchWindowsToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.macrosToolStripEx = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.macrosToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton
            Me.viewMacrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.reToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pauseMacroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripButton7 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton8 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton9 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator27 = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripButton18 = New System.Windows.Forms.ToolStripButton
            Me.officeSplitButton1 = New Syncfusion.Windows.Forms.Tools.OfficeSplitButton
            Me.officeButton1 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeButton2 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeButton3 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeButton4 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeButton5 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.toolStripSeparator28 = New System.Windows.Forms.ToolStripSeparator
            Me.officeSplitButton2 = New Syncfusion.Windows.Forms.Tools.OfficeSplitButton
            Me.officeButton6 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeButton7 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeButton8 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeDropDownButton1 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
            Me.officeButton9 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeButton10 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeButton11 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeButton12 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeButton13 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeButton14 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeButton15 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeDropDownButton3 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
            Me.officeButton16 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeButton17 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeDropDownButton4 = New Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
            Me.officeButton18 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeButton19 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.officeButton20 = New Syncfusion.Windows.Forms.Tools.OfficeButton
            Me.toolStripSeparator29 = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton
            Me.saveToolstripBtn = New System.Windows.Forms.ToolStripButton
            Me.undoToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.redoToolStripBtn = New System.Windows.Forms.ToolStripButton
            Me.superAccelerator = New Syncfusion.Windows.Forms.Tools.SuperAccelerator(Me)
            Me.superToolTip1 = New Syncfusion.Windows.Forms.Tools.SuperToolTip(Me)
            Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton19 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton20 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton21 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton22 = New System.Windows.Forms.ToolStripButton
            Me.statusStripButton4 = New Syncfusion.Windows.Forms.Tools.StatusStripButton
            Me.statusStripButton5 = New Syncfusion.Windows.Forms.Tools.StatusStripButton
            Me.statusStripButton1 = New Syncfusion.Windows.Forms.Tools.StatusStripButton
            Me.statusStripButton2 = New Syncfusion.Windows.Forms.Tools.StatusStripButton
            Me.fontListBox1 = New Syncfusion.Windows.Forms.Tools.FontListBox
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.EditorContextMenuStripEx = New Syncfusion.Windows.Forms.Tools.ContextMenuStripEx
            Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator30 = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem
            Me.gridLayout1 = New Syncfusion.Windows.Forms.Tools.GridLayout(Me.components)
            Me.progressTimer = New System.Windows.Forms.Timer(Me.components)
            Me.statusStripEx1 = New Syncfusion.Windows.Forms.Tools.StatusStripEx
            Me.trackBarItem1 = New Syncfusion.Windows.Forms.Tools.TrackBarItem
            Me.MiniToolBar = New Syncfusion.Windows.Forms.Tools.MiniToolBar
            Me.MiniToolBarPanelItem = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.PanelItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.FontFaceCombo = New System.Windows.Forms.ToolStripComboBox
            Me.FontSize = New System.Windows.Forms.ToolStripComboBox
            Me.toolStripButton10 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton11 = New System.Windows.Forms.ToolStripButton
            Me.PanelItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripButton12 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton13 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton14 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton17 = New System.Windows.Forms.ToolStripButton
            Me.toolStripSplitButton1 = New System.Windows.Forms.ToolStripButton
            Me.toolStripSplitButton2 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton15 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton16 = New System.Windows.Forms.ToolStripButton
            Me.SplashControl1 = New Syncfusion.Windows.Forms.Tools.SplashControl
            Me.SplashPanel1 = New Syncfusion.Windows.Forms.Tools.SplashPanel
            Me.statusStripLabel1 = New Syncfusion.Windows.Forms.Tools.StatusStripLabel
            CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ribbonControlAdv1.SuspendLayout()
            Me.homeTabItem.Panel.SuspendLayout()
            Me.clipboardToolStripExt.SuspendLayout()
            Me.fontToolStripExt.SuspendLayout()
            Me.paragraphToolStripExt.SuspendLayout()
            Me.stylesToolStripExt.SuspendLayout()
            Me.editingToolStripExt.SuspendLayout()
            Me.insertTabItem.Panel.SuspendLayout()
            Me.pagesToolStripExt.SuspendLayout()
            Me.tablesToolStripExt.SuspendLayout()
            Me.linksToolStripExt.SuspendLayout()
            Me.headerToolStripExt.SuspendLayout()
            Me.textToolStripExt.SuspendLayout()
            Me.symbolsToolStripExt.SuspendLayout()
            Me.pageLayoutTabItem.Panel.SuspendLayout()
            Me.themesToolStripExt.SuspendLayout()
            Me.pageSetupToolStripExt.SuspendLayout()
            Me.pageBackgroundToolStripExt.SuspendLayout()
            Me.paraToolStripExt.SuspendLayout()
            Me.arrangeToolStripExt.SuspendLayout()
            Me.referencesTabItem.Panel.SuspendLayout()
            Me.tbofContentsToolStripExt.SuspendLayout()
            Me.footNotesToolStripExt.SuspendLayout()
            Me.citationsToolStripExt.SuspendLayout()
            Me.captionsToolStripExt.SuspendLayout()
            Me.indexToolStripExt.SuspendLayout()
            Me.tbofAuthoritiesToolStripExt.SuspendLayout()
            Me.mailingsTabItem.Panel.SuspendLayout()
            Me.createToolStripExt.SuspendLayout()
            Me.stMailMergeToolStripExt.SuspendLayout()
            Me.insertFieldsToolStripExt.SuspendLayout()
            Me.previewResultsToolStripExt.SuspendLayout()
            Me.finishToolStripExt.SuspendLayout()
            Me.reviewTabItem.Panel.SuspendLayout()
            Me.proofingToolStripExt.SuspendLayout()
            Me.commentsToolStripExt.SuspendLayout()
            Me.trackingToolStripExt.SuspendLayout()
            Me.changesToolStripExt.SuspendLayout()
            Me.compareToolStripExt.SuspendLayout()
            Me.toolStripEx6.SuspendLayout()
            Me.viewTabItem.Panel.SuspendLayout()
            Me.docViewsToolStripExt.SuspendLayout()
            Me.showToolStripExt.SuspendLayout()
            Me.zoomToolStripExt.SuspendLayout()
            Me.windowToolStripExt.SuspendLayout()
            Me.macrosToolStripEx.SuspendLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            Me.EditorContextMenuStripEx.SuspendLayout()
            CType(Me.gridLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.statusStripEx1.SuspendLayout()
            Me.MiniToolBar.SuspendLayout()
            Me.SuspendLayout()
            '
            'ribbonControlAdv1
            '
            Me.ribbonControlAdv1.Header.AddMainItem(homeTabItem)
            Me.ribbonControlAdv1.Header.AddMainItem(insertTabItem)
            Me.ribbonControlAdv1.Header.AddMainItem(pageLayoutTabItem)
            Me.ribbonControlAdv1.Header.AddMainItem(referencesTabItem)
            Me.ribbonControlAdv1.Header.AddMainItem(mailingsTabItem)
            Me.ribbonControlAdv1.Header.AddMainItem(reviewTabItem)
            Me.ribbonControlAdv1.Header.AddMainItem(viewTabItem)
            Me.ribbonControlAdv1.Location = New System.Drawing.Point(1, 0)

            Me.ribbonControlAdv1.SuperAccelerator = superAccelerator
            Me.superAccelerator.SetMenuButtonAccelerator(Me.ribbonControlAdv1, "F")
            Me.ribbonControlAdv1.MenuButtonImage = CType(resources.GetObject("ribbonControlAdv1.MenuButtonImage"), System.Drawing.Image)
            ToolTipInfo6.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(239, Byte), Integer))
            ToolTipInfo6.Body.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            ToolTipInfo6.Body.Text = "Click here to open, save or print" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and to see everything  you can do " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with your " & _
                "document."
            ToolTipInfo6.Body.TextMargin = New System.Windows.Forms.Padding(5)
            ToolTipInfo6.Footer.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            ToolTipInfo6.Footer.Text = "Press F1 for more help"
            ToolTipInfo6.Footer.TextMargin = New System.Windows.Forms.Padding(10)
            ToolTipInfo6.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo6.Header.Text = "Office Menu Button"
            ToolTipInfo6.Header.TextMargin = New System.Windows.Forms.Padding(10)
            Me.superToolTip1.SetMenuButtonToolTip(Me.ribbonControlAdv1, ToolTipInfo6)
            Me.ribbonControlAdv1.Name = "ribbonControlAdv1"
            '
            'ribbonControlAdv1.OfficeMenu
            '
            Me.ribbonControlAdv1.OfficeMenu.AutoSize = False
            Me.ribbonControlAdv1.OfficeMenu.AuxPanel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ribbonControlAdv1.OfficeMenu.AuxPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton7, Me.toolStripButton8, Me.toolStripButton9})
            Me.ribbonControlAdv1.OfficeMenu.AuxPanel.SeparatorIndent = 16
            Me.ribbonControlAdv1.OfficeMenu.AuxPanel.Text = "Recent Documents"
            Me.ribbonControlAdv1.OfficeMenu.MainPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton1, Me.toolStripButton2, Me.toolStripSeparator27, Me.toolStripButton18, Me.officeSplitButton1, Me.toolStripSeparator28, Me.officeSplitButton2, Me.officeDropDownButton1, Me.officeDropDownButton3, Me.officeDropDownButton4, Me.toolStripSeparator29, Me.toolStripButton3})
            Me.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu"
            Me.ribbonControlAdv1.OfficeMenu.Size = New System.Drawing.Size(400, 466)
            Me.ribbonControlAdv1.OfficeMenu.SystemPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton6, Me.toolStripButton4})
            Me.ribbonControlAdv1.Size = New System.Drawing.Size(1008, 151)
            Me.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu"
            ToolStripTabGroup1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            ToolStripTabGroup1.Name = "Layout"
            ToolStripTabGroup1.Visible = True
            ToolStripTabGroup2.Color = System.Drawing.Color.YellowGreen
            ToolStripTabGroup2.Name = "View Group"
            ToolStripTabGroup2.Visible = True
            Me.ribbonControlAdv1.TabGroups.Add(ToolStripTabGroup1)
            Me.ribbonControlAdv1.TabGroups.Add(ToolStripTabGroup2)
            Me.ribbonControlAdv1.TabGroups.SetTabGroup(pageLayoutTabItem, ToolStripTabGroup1)
            Me.ribbonControlAdv1.TabGroups.SetTabGroup(reviewTabItem, ToolStripTabGroup2)
            Me.ribbonControlAdv1.TabIndex = 0
            Me.ribbonControlAdv1.Text = "ribbonControlAdv1"
            Me.ribbonControlAdv1.TitleAlignment = Syncfusion.Windows.Forms.Tools.TextAlignment.Center
            Me.ribbonControlAdv1.TitleFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            'homeTabItem
            '
            Me.superAccelerator.SetAccelerator(Me.homeTabItem, "H")
            Me.homeTabItem.ForeColor = System.Drawing.Color.MidnightBlue
            Me.homeTabItem.Name = "homeTabItem"
            Me.homeTabItem.Padding = New System.Windows.Forms.Padding(15, 2, 3, 5)
            '
            'ribbonControlAdv1.RibbonPanel1
            '
            Me.homeTabItem.Panel.Controls.Add(Me.clipboardToolStripExt)
            Me.homeTabItem.Panel.Controls.Add(Me.fontToolStripExt)
            Me.homeTabItem.Panel.Controls.Add(Me.paragraphToolStripExt)
            Me.homeTabItem.Panel.Controls.Add(Me.stylesToolStripExt)
            Me.homeTabItem.Panel.Controls.Add(Me.editingToolStripExt)
            Me.homeTabItem.Panel.Name = "RibbonPanel1"
            Me.homeTabItem.Panel.ScrollPosition = 0
            Me.homeTabItem.Panel.TabIndex = 1
            Me.homeTabItem.Panel.Text = "Home"
            Me.homeTabItem.Size = New System.Drawing.Size(56, 24)
            Me.homeTabItem.Text = "Home"
            '
            'clipboardToolStripExt
            '
			Me.clipboardToolStripExt.AutoSize = False
            Me.clipboardToolStripExt.CollapsedDropDownButtonText = "Clipboard"
            Me.clipboardToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.clipboardToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.clipboardToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.clipboardToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.clipboardToolStripExt.Image = CType(resources.GetObject("clipboardToolStripExt.Image"), System.Drawing.Image)
            Me.clipboardToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem15, Me.toolStripPanelItem1})
            Me.clipboardToolStripExt.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007
            Me.clipboardToolStripExt.Location = New System.Drawing.Point(0, 1)
            Me.clipboardToolStripExt.Name = "clipboardToolStripExt"
            Me.clipboardToolStripExt.Size = New System.Drawing.Size(96, 88)
            Me.clipboardToolStripExt.TabIndex = 0
            Me.clipboardToolStripExt.Text = "Clipboard"
            '
            'toolStripPanelItem15
            '
            Me.toolStripPanelItem15.CausesValidation = False
            Me.toolStripPanelItem15.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem15.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripBtnPaste, Me.toolStripDropDownBtnPaste})
            Me.toolStripPanelItem15.Name = "toolStripPanelItem15"
            Me.toolStripPanelItem15.Size = New System.Drawing.Size(42, 70)
            Me.toolStripPanelItem15.Text = "toolStripPanelItem15"
            Me.toolStripPanelItem15.Transparent = True
            '
            'toolStripBtnPaste
            '
            Me.superAccelerator.SetAccelerator(Me.toolStripBtnPaste, "V")
            Me.toolStripBtnPaste.AutoToolTip = False
            Me.toolStripBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripBtnPaste.Image = CType(resources.GetObject("toolStripBtnPaste.Image"), System.Drawing.Image)
            Me.toolStripBtnPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripBtnPaste.Name = "toolStripBtnPaste"
            Me.toolStripBtnPaste.Size = New System.Drawing.Size(36, 36)
            Me.toolStripBtnPaste.Text = "toolStripButton39"
            ToolTipInfo41.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo41.Body.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo41.Body.Text = "Paste the contents of the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clipboard."
            ToolTipInfo41.Body.TextMargin = New System.Windows.Forms.Padding(10, 5, 0, 0)
            ToolTipInfo41.Footer.Hidden = True
            ToolTipInfo41.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo41.Header.Text = "Paste"
            ToolTipInfo41.Separator = False
            Me.superToolTip1.SetToolTip(Me.toolStripBtnPaste, ToolTipInfo41)
            '
            'toolStripDropDownBtnPaste
            '
            Me.toolStripDropDownBtnPaste.AutoToolTip = False
            Me.toolStripDropDownBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.toolStripDropDownBtnPaste.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pasteToolStripMenuItem, Me.pasteSpecialToolStripMenuItem, Me.pasteAsHyperlinkToolStripMenuItem})
            Me.toolStripDropDownBtnPaste.Image = CType(resources.GetObject("toolStripDropDownBtnPaste.Image"), System.Drawing.Image)
            Me.toolStripDropDownBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripDropDownBtnPaste.Name = "toolStripDropDownBtnPaste"
            Me.SetShortcut(Me.toolStripDropDownBtnPaste, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys))
            Me.toolStripDropDownBtnPaste.ShowDropDownArrow = False
            Me.toolStripDropDownBtnPaste.Size = New System.Drawing.Size(38, 17)
            Me.toolStripDropDownBtnPaste.Text = "Paste"
            ToolTipInfo42.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo42.Body.Text = "Click here for more options such as " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pasting only the values or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "formatting."
            ToolTipInfo42.Body.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo42.Body.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ToolTipInfo42.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo42.Footer.ImageScalingSize = New System.Drawing.Size(16, 16)
            ToolTipInfo42.Footer.Text = ""
            ToolTipInfo42.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo42.Header.Text = "Paste"
            ToolTipInfo42.Separator = False
            Me.superToolTip1.SetToolTip(Me.toolStripDropDownBtnPaste, ToolTipInfo42)
            '
            'pasteToolStripMenuItem
            '
            Me.pasteToolStripMenuItem.Image = CType(resources.GetObject("pasteToolStripMenuItem.Image"), System.Drawing.Image)
            Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
            Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
            Me.pasteToolStripMenuItem.Text = "&Paste"
            '
            'pasteSpecialToolStripMenuItem
            '
            Me.pasteSpecialToolStripMenuItem.Image = CType(resources.GetObject("pasteSpecialToolStripMenuItem.Image"), System.Drawing.Image)
            Me.pasteSpecialToolStripMenuItem.Name = "pasteSpecialToolStripMenuItem"
            Me.pasteSpecialToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
            Me.pasteSpecialToolStripMenuItem.Text = "Paste &Special..."
            '
            'pasteAsHyperlinkToolStripMenuItem
            '
            Me.pasteAsHyperlinkToolStripMenuItem.Enabled = False
            Me.pasteAsHyperlinkToolStripMenuItem.Image = CType(resources.GetObject("pasteAsHyperlinkToolStripMenuItem.Image"), System.Drawing.Image)
            Me.pasteAsHyperlinkToolStripMenuItem.Name = "pasteAsHyperlinkToolStripMenuItem"
            Me.pasteAsHyperlinkToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
            Me.pasteAsHyperlinkToolStripMenuItem.Text = "Paste as &Hyperlink"
            '
            'toolStripPanelItem1
            '
            Me.toolStripPanelItem1.CausesValidation = False
            Me.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripBtnCut, Me.toolStripBtnCopy, Me.toolStripBtnPaint})
            Me.toolStripPanelItem1.Name = "toolStripPanelItem1"
            Me.toolStripPanelItem1.Size = New System.Drawing.Size(27, 70)
            Me.toolStripPanelItem1.Text = "toolStripPanelItem1"
            Me.toolStripPanelItem1.Transparent = True
            '
            'toolStripBtnCut
            '
            Me.superAccelerator.SetAccelerator(Me.toolStripBtnCut, "X")
            Me.toolStripBtnCut.AutoToolTip = False
            Me.toolStripBtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripBtnCut.Image = CType(resources.GetObject("toolStripBtnCut.Image"), System.Drawing.Image)
            Me.toolStripBtnCut.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripBtnCut.Name = "toolStripBtnCut"
            Me.SetShortcut(Me.toolStripBtnCut, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys))
            Me.toolStripBtnCut.Size = New System.Drawing.Size(23, 20)
            Me.toolStripBtnCut.Text = "toolStripBtnCut"
            ToolTipInfo43.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo43.Body.Text = "Cut the selection from " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "document and put it on" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clipboard."
            ToolTipInfo43.Body.TextMargin = New System.Windows.Forms.Padding(5, 5, 0, 0)
            ToolTipInfo43.Footer.Hidden = True
            ToolTipInfo43.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo43.Header.Text = "Cut"
            ToolTipInfo43.Separator = False
            Me.superToolTip1.SetToolTip(Me.toolStripBtnCut, ToolTipInfo43)
            '
            'toolStripBtnCopy
            '
            Me.superAccelerator.SetAccelerator(Me.toolStripBtnCopy, "C")
            Me.toolStripBtnCopy.AutoToolTip = False
            Me.toolStripBtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripBtnCopy.Image = CType(resources.GetObject("toolStripBtnCopy.Image"), System.Drawing.Image)
            Me.toolStripBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripBtnCopy.Name = "toolStripBtnCopy"
            Me.SetShortcut(Me.toolStripBtnCopy, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys))
            Me.toolStripBtnCopy.Size = New System.Drawing.Size(23, 20)
            Me.toolStripBtnCopy.Text = "toolStripButton6"
            ToolTipInfo44.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo44.Body.Text = "Copy the selection and put it on" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the Clipboard."
            ToolTipInfo44.Body.TextMargin = New System.Windows.Forms.Padding(10, 5, 0, 0)
            ToolTipInfo44.Footer.Hidden = True
            ToolTipInfo44.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo44.Header.Text = "Copy"
            ToolTipInfo44.Separator = False
            Me.superToolTip1.SetToolTip(Me.toolStripBtnCopy, ToolTipInfo44)
            '
            'toolStripBtnPaint
            '
            Me.superAccelerator.SetAccelerator(Me.toolStripBtnPaint, "FP")
            Me.toolStripBtnPaint.AutoToolTip = False
            Me.toolStripBtnPaint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripBtnPaint.Image = CType(resources.GetObject("toolStripBtnPaint.Image"), System.Drawing.Image)
            Me.toolStripBtnPaint.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripBtnPaint.Name = "toolStripBtnPaint"
            Me.SetShortcut(Me.toolStripBtnPaint, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys))
            Me.toolStripBtnPaint.Size = New System.Drawing.Size(23, 20)
            Me.toolStripBtnPaint.Text = "toolStripButton7"
            ToolTipInfo45.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo45.Body.Text = "Copy formatting from one place" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and apply it to another." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Double-click this but" & _
                "ton to apply" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the same formatting to multiple " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "places in the document."
            ToolTipInfo45.Body.TextMargin = New System.Windows.Forms.Padding(10, 5, 0, 0)
            ToolTipInfo45.Footer.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            ToolTipInfo45.Footer.ImageScalingSize = New System.Drawing.Size(16, 16)
            ToolTipInfo45.Footer.Text = "Press F1 for more help."
            ToolTipInfo45.Footer.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            ToolTipInfo45.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo45.Header.Text = "Format Painter"
            Me.superToolTip1.SetToolTip(Me.toolStripBtnPaint, ToolTipInfo45)
            '
            'fontToolStripExt
            '
			Me.fontToolStripExt.AutoSize = False
            Me.fontToolStripExt.CollapsedDropDownButtonText = "Font"
            Me.fontToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.fontToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.fontToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.fontToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.fontToolStripExt.GroupedButtons = True
            Me.fontToolStripExt.Image = CType(resources.GetObject("fontToolStripExt.Image"), System.Drawing.Image)
            Me.fontToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem2, Me.toolStripPanelItem3, Me.toolStripPanelItem48, Me.toolStripPanelItem4, Me.toolStripPanelItem5, Me.toolStripPanelItem47, Me.toolStripPanelItem6})
            Me.fontToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.fontToolStripExt.Location = New System.Drawing.Point(96, 1)
            Me.fontToolStripExt.Name = "fontToolStripExt"
            Me.fontToolStripExt.Size = New System.Drawing.Size(270, 88)
            Me.fontToolStripExt.TabIndex = 1
            Me.fontToolStripExt.Text = "Font"
            ToolTipInfo58.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo58.Body.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
            ToolTipInfo58.Body.Text = "Show the font dialog box."
            ToolTipInfo58.Header.Text = "Font Dialog"
            ToolTipInfo58.Separator = False
            Me.superToolTip1.SetToolTip(Me.fontToolStripExt, ToolTipInfo58)
            '
            'toolStripPanelItem2
            '
            Me.toolStripPanelItem2.CausesValidation = False
            Me.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem2.GroupedButtons = True
            Me.toolStripPanelItem2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripFontfaceComboBox, Me.toolStripFontSizeComboBox})
            Me.toolStripPanelItem2.Name = "toolStripPanelItem2"
            Me.toolStripPanelItem2.RowCount = 1
            Me.toolStripPanelItem2.Size = New System.Drawing.Size(170, 25)
            Me.toolStripPanelItem2.Text = "toolStripPanelItem2"
            Me.toolStripPanelItem2.Transparent = True
            '
            'toolStripFontfaceComboBox
            '
            Me.superAccelerator.SetAccelerator(Me.toolStripFontfaceComboBox, "FF")
            Me.toolStripFontfaceComboBox.DropDownHeight = 120
            Me.toolStripFontfaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.toolStripFontfaceComboBox.IntegralHeight = False
            Me.toolStripFontfaceComboBox.Name = "toolStripFontfaceComboBox"
            Me.SetShortcut(Me.toolStripFontfaceComboBox, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys))
            Me.toolStripFontfaceComboBox.Size = New System.Drawing.Size(121, 21)
            '
            'toolStripFontSizeComboBox
            '
            Me.superAccelerator.SetAccelerator(Me.toolStripFontSizeComboBox, "FS")
            Me.toolStripFontSizeComboBox.AutoSize = False
            Me.toolStripFontSizeComboBox.DropDownHeight = 120
            Me.toolStripFontSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.toolStripFontSizeComboBox.IntegralHeight = False
            Me.toolStripFontSizeComboBox.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72"})
            Me.toolStripFontSizeComboBox.Name = "toolStripFontSizeComboBox"
            Me.SetShortcut(Me.toolStripFontSizeComboBox, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys))
            Me.toolStripFontSizeComboBox.Size = New System.Drawing.Size(41, 21)
            '
            'toolStripPanelItem3
            '
            Me.toolStripPanelItem3.CausesValidation = False
            Me.toolStripPanelItem3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem3.GroupedButtons = True
            Me.toolStripPanelItem3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.growfontToolStripBtn, Me.shrinkfontToolStripBtn})
            Me.toolStripPanelItem3.Name = "toolStripPanelItem3"
            Me.toolStripPanelItem3.RowCount = 1
            Me.toolStripPanelItem3.Size = New System.Drawing.Size(50, 29)
            Me.toolStripPanelItem3.Text = "toolStripPanelItem3"
            Me.toolStripPanelItem3.Transparent = True
            '
            'growfontToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.growfontToolStripBtn, "FG")
            Me.growfontToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.growfontToolStripBtn.Image = CType(resources.GetObject("growfontToolStripBtn.Image"), System.Drawing.Image)
            Me.growfontToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.growfontToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.growfontToolStripBtn.Name = "growfontToolStripBtn"
            Me.SetShortcut(Me.growfontToolStripBtn, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.OemPeriod), System.Windows.Forms.Keys))
            Me.growfontToolStripBtn.Size = New System.Drawing.Size(23, 22)
            Me.growfontToolStripBtn.Text = "growfontToolStripBtn"
            ToolTipInfo46.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo46.Body.Text = "Increase the font size."
            ToolTipInfo46.Body.TextMargin = New System.Windows.Forms.Padding(10, 5, 0, 0)
            ToolTipInfo46.Footer.Hidden = True
            ToolTipInfo46.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo46.Header.Text = "Grow Font"
            ToolTipInfo46.Separator = False
            Me.superToolTip1.SetToolTip(Me.growfontToolStripBtn, ToolTipInfo46)
            '
            'shrinkfontToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.shrinkfontToolStripBtn, "FK")
            Me.shrinkfontToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.shrinkfontToolStripBtn.Image = CType(resources.GetObject("shrinkfontToolStripBtn.Image"), System.Drawing.Image)
            Me.shrinkfontToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.shrinkfontToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.shrinkfontToolStripBtn.Name = "shrinkfontToolStripBtn"
            Me.SetShortcut(Me.shrinkfontToolStripBtn, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Oemcomma), System.Windows.Forms.Keys))
            Me.shrinkfontToolStripBtn.Size = New System.Drawing.Size(23, 22)
            Me.shrinkfontToolStripBtn.Text = "shrinkfontToolStripBtn"
            ToolTipInfo47.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo47.Body.Text = "Decrease the font size."
            ToolTipInfo47.Body.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ToolTipInfo47.Footer.Hidden = True
            ToolTipInfo47.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo47.Header.Text = "Shrink Font"
            ToolTipInfo47.Separator = False
            Me.superToolTip1.SetToolTip(Me.shrinkfontToolStripBtn, ToolTipInfo47)
            '
            'toolStripPanelItem48
            '
            Me.toolStripPanelItem48.CausesValidation = False
            Me.toolStripPanelItem48.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem48.GroupedButtons = True
            Me.toolStripPanelItem48.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.clearToolstripBtn})
            Me.toolStripPanelItem48.Name = "toolStripPanelItem48"
            Me.toolStripPanelItem48.Size = New System.Drawing.Size(27, 27)
            Me.toolStripPanelItem48.Text = "toolStripPanelItem48"
            Me.toolStripPanelItem48.Transparent = True
            '
            'clearToolstripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.clearToolstripBtn, "E")
            Me.clearToolstripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.clearToolstripBtn.Image = CType(resources.GetObject("clearToolstripBtn.Image"), System.Drawing.Image)
            Me.clearToolstripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.clearToolstripBtn.Name = "clearToolstripBtn"
            Me.clearToolstripBtn.Size = New System.Drawing.Size(23, 20)
            Me.clearToolstripBtn.Text = "clearToolstripBtn"
            ToolTipInfo48.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo48.Body.Text = "Clear all the formatting from the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "selection, leaving only the plain" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "text."
            ToolTipInfo48.Body.TextMargin = New System.Windows.Forms.Padding(10, 5, 0, 0)
            ToolTipInfo48.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo48.Footer.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
            ToolTipInfo48.Footer.ImageScalingSize = New System.Drawing.Size(16, 16)
            ToolTipInfo48.Footer.Text = "Press F1 for more help."
            ToolTipInfo48.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo48.Header.Text = "Clear Formatting"
            Me.superToolTip1.SetToolTip(Me.clearToolstripBtn, ToolTipInfo48)
            '
            'toolStripPanelItem4
            '
            Me.toolStripPanelItem4.CausesValidation = False
            Me.toolStripPanelItem4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem4.GroupedButtons = True
            Me.toolStripPanelItem4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boldToolstripBtn, Me.italicToolStripBtn, Me.underlineToolStripSplitBtn, Me.strikethroToolStripBtn})
            Me.toolStripPanelItem4.Name = "toolStripPanelItem4"
            Me.toolStripPanelItem4.RowCount = 1
            Me.toolStripPanelItem4.Size = New System.Drawing.Size(105, 27)
            Me.toolStripPanelItem4.Text = "toolStripPanelItem4"
            Me.toolStripPanelItem4.Transparent = True
            '
            'boldToolstripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.boldToolstripBtn, "1")
            Me.boldToolstripBtn.AutoToolTip = False
            Me.boldToolstripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.boldToolstripBtn.Image = CType(resources.GetObject("boldToolstripBtn.Image"), System.Drawing.Image)
            Me.boldToolstripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.boldToolstripBtn.Name = "boldToolstripBtn"
            Me.SetShortcut(Me.boldToolstripBtn, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys))
            Me.boldToolstripBtn.Size = New System.Drawing.Size(23, 20)
            Me.boldToolstripBtn.Text = "boldToolstripBtn"
            ToolTipInfo49.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo49.Body.Text = "Make the selected text bold."
            ToolTipInfo49.Body.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            ToolTipInfo49.Footer.Hidden = True
            ToolTipInfo49.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo49.Header.Text = "Bold"
            ToolTipInfo49.Separator = False
            Me.superToolTip1.SetToolTip(Me.boldToolstripBtn, ToolTipInfo49)
            '
            'italicToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.italicToolStripBtn, "2")
            Me.italicToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.italicToolStripBtn.Image = CType(resources.GetObject("italicToolStripBtn.Image"), System.Drawing.Image)
            Me.italicToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.italicToolStripBtn.Name = "italicToolStripBtn"
            Me.SetShortcut(Me.italicToolStripBtn, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys))
            Me.italicToolStripBtn.Size = New System.Drawing.Size(23, 20)
            Me.italicToolStripBtn.Text = "italicToolStripBtn"
            ToolTipInfo50.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo50.Body.Text = "Italicize the selected text."
            ToolTipInfo50.Body.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            ToolTipInfo50.Footer.Hidden = True
            ToolTipInfo50.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo50.Header.Text = "Italic"
            ToolTipInfo50.Separator = False
            Me.superToolTip1.SetToolTip(Me.italicToolStripBtn, ToolTipInfo50)
            '
            'underlineToolStripSplitBtn
            '
            Me.superAccelerator.SetAccelerator(Me.underlineToolStripSplitBtn, "3")
            Me.underlineToolStripSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.underlineToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.moreUnderlinesToolStripMenuItem, Me.underlineColorToolStripMenuItem})
            Me.underlineToolStripSplitBtn.Image = CType(resources.GetObject("underlineToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.underlineToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.underlineToolStripSplitBtn.Name = "underlineToolStripSplitBtn"
            Me.SetShortcut(Me.underlineToolStripSplitBtn, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys))
            Me.underlineToolStripSplitBtn.Size = New System.Drawing.Size(32, 20)
            Me.underlineToolStripSplitBtn.Text = "underlineToolStripSplitBtn"
            ToolTipInfo51.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo51.Body.Text = "Underline the selected text."
            ToolTipInfo51.Body.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            ToolTipInfo51.Footer.Hidden = True
            ToolTipInfo51.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo51.Header.Text = "Underline"
            ToolTipInfo51.Separator = False
            Me.superToolTip1.SetToolTip(Me.underlineToolStripSplitBtn, ToolTipInfo51)
            '
            'moreUnderlinesToolStripMenuItem
            '
            Me.moreUnderlinesToolStripMenuItem.Name = "moreUnderlinesToolStripMenuItem"
            Me.moreUnderlinesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
            Me.moreUnderlinesToolStripMenuItem.Text = "&More Underlines..."
            '
            'underlineColorToolStripMenuItem
            '
            Me.underlineColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.automaticToolStripMenuItem, Me.moreColorsToolStripMenuItem})
            Me.underlineColorToolStripMenuItem.Image = CType(resources.GetObject("underlineColorToolStripMenuItem.Image"), System.Drawing.Image)
            Me.underlineColorToolStripMenuItem.Name = "underlineColorToolStripMenuItem"
            Me.underlineColorToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
            Me.underlineColorToolStripMenuItem.Text = "&Underline Color"
            '
            'automaticToolStripMenuItem
            '
            Me.automaticToolStripMenuItem.Name = "automaticToolStripMenuItem"
            Me.automaticToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
            Me.automaticToolStripMenuItem.Text = "&Automatic"
            '
            'moreColorsToolStripMenuItem
            '
            Me.moreColorsToolStripMenuItem.Name = "moreColorsToolStripMenuItem"
            Me.moreColorsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
            Me.moreColorsToolStripMenuItem.Text = "&More Colors..."
            '
            'strikethroToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.strikethroToolStripBtn, "4")
            Me.strikethroToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.strikethroToolStripBtn.Image = CType(resources.GetObject("strikethroToolStripBtn.Image"), System.Drawing.Image)
            Me.strikethroToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.strikethroToolStripBtn.Name = "strikethroToolStripBtn"
            Me.strikethroToolStripBtn.Size = New System.Drawing.Size(23, 20)
            Me.strikethroToolStripBtn.Text = "strikethroToolStripBtn"
            ToolTipInfo52.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo52.Body.Text = "Draw a line through the middle of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the selected text."
            ToolTipInfo52.Body.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            ToolTipInfo52.Footer.Hidden = True
            ToolTipInfo52.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo52.Header.Text = "Strikethrough"
            ToolTipInfo52.Separator = False
            Me.superToolTip1.SetToolTip(Me.strikethroToolStripBtn, ToolTipInfo52)
            '
            'toolStripPanelItem5
            '
            Me.toolStripPanelItem5.CausesValidation = False
            Me.toolStripPanelItem5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem5.GroupedButtons = True
            Me.toolStripPanelItem5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subscriptToolStripBtn, Me.superscriptToolStripBtn})
            Me.toolStripPanelItem5.Name = "toolStripPanelItem5"
            Me.toolStripPanelItem5.RowCount = 1
            Me.toolStripPanelItem5.Size = New System.Drawing.Size(50, 27)
            Me.toolStripPanelItem5.Text = "toolStripPanelItem5"
            Me.toolStripPanelItem5.Transparent = True
            '
            'subscriptToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.subscriptToolStripBtn, "5")
            Me.subscriptToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.subscriptToolStripBtn.Image = CType(resources.GetObject("subscriptToolStripBtn.Image"), System.Drawing.Image)
            Me.subscriptToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.subscriptToolStripBtn.Name = "subscriptToolStripBtn"
            Me.SetShortcut(Me.subscriptToolStripBtn, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Oemplus), System.Windows.Forms.Keys))
            Me.subscriptToolStripBtn.Size = New System.Drawing.Size(23, 20)
            Me.subscriptToolStripBtn.Text = "subscriptToolStripBtn"
            ToolTipInfo53.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo53.Body.Text = "Create small letters below the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "baseline."
            ToolTipInfo53.Body.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            ToolTipInfo53.Footer.Hidden = True
            ToolTipInfo53.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo53.Header.Text = "Subscript"
            ToolTipInfo53.Separator = False
            Me.superToolTip1.SetToolTip(Me.subscriptToolStripBtn, ToolTipInfo53)
            '
            'superscriptToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.superscriptToolStripBtn, "6")
            Me.superscriptToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.superscriptToolStripBtn.Image = CType(resources.GetObject("superscriptToolStripBtn.Image"), System.Drawing.Image)
            Me.superscriptToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.superscriptToolStripBtn.Name = "superscriptToolStripBtn"
            Me.SetShortcut(Me.superscriptToolStripBtn, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                            Or System.Windows.Forms.Keys.Oemplus), System.Windows.Forms.Keys))
            Me.superscriptToolStripBtn.Size = New System.Drawing.Size(23, 20)
            Me.superscriptToolStripBtn.Text = "superscriptToolStripBtn"
            ToolTipInfo54.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo54.Body.Text = "Create small letters above the line" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the text."
            ToolTipInfo54.Body.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            ToolTipInfo54.Footer.Hidden = True
            ToolTipInfo54.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo54.Header.Text = "Superscript"
            ToolTipInfo54.Separator = False
            Me.superToolTip1.SetToolTip(Me.superscriptToolStripBtn, ToolTipInfo54)
            '
            'toolStripPanelItem47
            '
            Me.toolStripPanelItem47.CausesValidation = False
            Me.toolStripPanelItem47.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem47.GroupedButtons = True
            Me.toolStripPanelItem47.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.changecaseToolStripBtn})
            Me.toolStripPanelItem47.Name = "toolStripPanelItem47"
            Me.toolStripPanelItem47.RowCount = 1
            Me.toolStripPanelItem47.Size = New System.Drawing.Size(33, 27)
            Me.toolStripPanelItem47.Text = "toolStripPanelItem47"
            Me.toolStripPanelItem47.Transparent = True
            '
            'changecaseToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.changecaseToolStripBtn, "7")
            Me.changecaseToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.changecaseToolStripBtn.Image = CType(resources.GetObject("changecaseToolStripBtn.Image"), System.Drawing.Image)
            Me.changecaseToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.changecaseToolStripBtn.Name = "changecaseToolStripBtn"
            Me.changecaseToolStripBtn.Size = New System.Drawing.Size(29, 20)
            Me.changecaseToolStripBtn.Text = "changecaseToolStripBtn"
            ToolTipInfo55.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo55.Body.Text = "Change all the selected text to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UPPERCASE, lowercase or other" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "common capitaliza" & _
                "tions."
            ToolTipInfo55.Body.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            ToolTipInfo55.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo55.Footer.Hidden = True
            ToolTipInfo55.Footer.ImageScalingSize = New System.Drawing.Size(16, 16)
            ToolTipInfo55.Footer.Text = ""
            ToolTipInfo55.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo55.Header.Text = "Change Case"
            ToolTipInfo55.Separator = False
            Me.superToolTip1.SetToolTip(Me.changecaseToolStripBtn, ToolTipInfo55)
            '
            'toolStripPanelItem6
            '
            Me.toolStripPanelItem6.CausesValidation = False
            Me.toolStripPanelItem6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem6.GroupedButtons = True
            Me.toolStripPanelItem6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txthighltToolStripsplitBtn, Me.fontcolorToolStripSplitBtn})
            Me.toolStripPanelItem6.Name = "toolStripPanelItem6"
            Me.toolStripPanelItem6.RowCount = 1
            Me.toolStripPanelItem6.Size = New System.Drawing.Size(68, 27)
            Me.toolStripPanelItem6.Text = "toolStripPanelItem6"
            Me.toolStripPanelItem6.Transparent = True
            '
            'txthighltToolStripsplitBtn
            '
            Me.superAccelerator.SetAccelerator(Me.txthighltToolStripsplitBtn, "I")
            Me.txthighltToolStripsplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.txthighltToolStripsplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.noColorToolStripMenuItem, Me.toolStripSeparator8, Me.stopHighlightingToolStripMenuItem})
            Me.txthighltToolStripsplitBtn.Image = CType(resources.GetObject("txthighltToolStripsplitBtn.Image"), System.Drawing.Image)
            Me.txthighltToolStripsplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.txthighltToolStripsplitBtn.Name = "txthighltToolStripsplitBtn"
            Me.txthighltToolStripsplitBtn.Size = New System.Drawing.Size(32, 20)
            Me.txthighltToolStripsplitBtn.Text = "txthighltToolStripsplitBtn"
            ToolTipInfo56.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo56.Body.Text = "Make text look like it was marker " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with a highlighter pen."
            ToolTipInfo56.Body.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            ToolTipInfo56.Footer.Hidden = True
            ToolTipInfo56.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo56.Header.Text = "Text Highlight Color"
            ToolTipInfo56.Separator = False
            Me.superToolTip1.SetToolTip(Me.txthighltToolStripsplitBtn, ToolTipInfo56)
            '
            'noColorToolStripMenuItem
            '
            Me.noColorToolStripMenuItem.Image = CType(resources.GetObject("noColorToolStripMenuItem.Image"), System.Drawing.Image)
            Me.noColorToolStripMenuItem.Name = "noColorToolStripMenuItem"
            Me.noColorToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
            Me.noColorToolStripMenuItem.Text = "&No Color"
            '
            'toolStripSeparator8
            '
            Me.toolStripSeparator8.Name = "toolStripSeparator8"
            Me.toolStripSeparator8.Size = New System.Drawing.Size(162, 6)
            '
            'stopHighlightingToolStripMenuItem
            '
            Me.stopHighlightingToolStripMenuItem.Enabled = False
            Me.stopHighlightingToolStripMenuItem.Name = "stopHighlightingToolStripMenuItem"
            Me.stopHighlightingToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
            Me.stopHighlightingToolStripMenuItem.Text = "&Stop Highlighting"
            '
            'fontcolorToolStripSplitBtn
            '
            Me.superAccelerator.SetAccelerator(Me.fontcolorToolStripSplitBtn, "FC")
            Me.fontcolorToolStripSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.fontcolorToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.automaticToolStripMenuItem1, Me.themeColorToolStripMenuItem, Me.moreColorsToolStripMenuItem1})
            Me.fontcolorToolStripSplitBtn.Image = CType(resources.GetObject("fontcolorToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.fontcolorToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.fontcolorToolStripSplitBtn.Name = "fontcolorToolStripSplitBtn"
            Me.fontcolorToolStripSplitBtn.Size = New System.Drawing.Size(32, 20)
            Me.fontcolorToolStripSplitBtn.Text = "fontcolorToolStripSplitBtn"
            ToolTipInfo57.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo57.Body.Text = "Change the text color."
            ToolTipInfo57.Body.TextMargin = New System.Windows.Forms.Padding(10, 5, 0, 5)
            ToolTipInfo57.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo57.Footer.Hidden = True
            ToolTipInfo57.Footer.ImageScalingSize = New System.Drawing.Size(16, 16)
            ToolTipInfo57.Footer.Text = "Press F1 for more help."
            ToolTipInfo57.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo57.Header.Text = "Font Color"
            ToolTipInfo57.Separator = False
            Me.superToolTip1.SetToolTip(Me.fontcolorToolStripSplitBtn, ToolTipInfo57)
            '
            'automaticToolStripMenuItem1
            '
            Me.automaticToolStripMenuItem1.Name = "automaticToolStripMenuItem1"
            Me.automaticToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
            Me.automaticToolStripMenuItem1.Text = "&Automatic"
            '
            'themeColorToolStripMenuItem
            '
            Me.themeColorToolStripMenuItem.Name = "themeColorToolStripMenuItem"
            Me.themeColorToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
            Me.themeColorToolStripMenuItem.Text = "Theme Color"
            '
            'moreColorsToolStripMenuItem1
            '
            Me.moreColorsToolStripMenuItem1.Image = CType(resources.GetObject("moreColorsToolStripMenuItem1.Image"), System.Drawing.Image)
            Me.moreColorsToolStripMenuItem1.Name = "moreColorsToolStripMenuItem1"
            Me.moreColorsToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
            Me.moreColorsToolStripMenuItem1.Text = "More Colors..."
            '
            'paragraphToolStripExt
            '
			Me.paragraphToolStripExt.AutoSize = False
            Me.paragraphToolStripExt.CollapsedDropDownButtonText = "Paragraph"
            Me.paragraphToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.paragraphToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.paragraphToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.paragraphToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.paragraphToolStripExt.GroupedButtons = True
            Me.paragraphToolStripExt.Image = CType(resources.GetObject("paragraphToolStripExt.Image"), System.Drawing.Image)
            Me.paragraphToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem7, Me.toolStripPanelItem8, Me.toolStripPanelItem9, Me.lAlignToolStripBtn, Me.centerToolStripBtn, Me.rAlignToolStripBtn, Me.justifyToolStripBtn, Me.lspacingToolStripDropDwnBtn, Me.shadingToolStripSplitBtn, Me.btmborderToolStripSplitBtn})
            Me.paragraphToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.paragraphToolStripExt.Location = New System.Drawing.Point(366, 1)
            Me.paragraphToolStripExt.Name = "paragraphToolStripExt"
            Me.paragraphToolStripExt.Size = New System.Drawing.Size(195, 88)
            Me.paragraphToolStripExt.TabIndex = 2
            Me.paragraphToolStripExt.Text = "Paragraph"
            '
            'toolStripPanelItem7
            '
            Me.toolStripPanelItem7.CausesValidation = False
            Me.toolStripPanelItem7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem7.GroupedButtons = True
            Me.toolStripPanelItem7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bulletToolStripSplitBtn, Me.numberingToolStripSplitBtn, Me.multilevelToolStripSplitBtn})
            Me.toolStripPanelItem7.Name = "toolStripPanelItem7"
            Me.toolStripPanelItem7.RowCount = 1
            Me.toolStripPanelItem7.Size = New System.Drawing.Size(100, 27)
            Me.toolStripPanelItem7.Text = "toolStripPanelItem7"
            Me.toolStripPanelItem7.Transparent = True
            '
            'bulletToolStripSplitBtn
            '
            Me.superAccelerator.SetAccelerator(Me.bulletToolStripSplitBtn, "U")
            Me.bulletToolStripSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bulletToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.changeListLevelToolStripMenuItem, Me.defineNewBulletToolStripMenuItem})
            Me.bulletToolStripSplitBtn.Image = CType(resources.GetObject("bulletToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.bulletToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bulletToolStripSplitBtn.Name = "bulletToolStripSplitBtn"
            Me.bulletToolStripSplitBtn.Size = New System.Drawing.Size(32, 20)
            Me.bulletToolStripSplitBtn.Text = "bulletToolStripSplitBtn"
            ToolTipInfo59.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo59.Body.Text = "Start a bulleted list."
            ToolTipInfo59.Body.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ToolTipInfo59.Footer.Hidden = True
            ToolTipInfo59.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo59.Header.Text = "Bullets"
            ToolTipInfo59.Separator = False
            Me.superToolTip1.SetToolTip(Me.bulletToolStripSplitBtn, ToolTipInfo59)
            '
            'changeListLevelToolStripMenuItem
            '
            Me.changeListLevelToolStripMenuItem.Image = CType(resources.GetObject("changeListLevelToolStripMenuItem.Image"), System.Drawing.Image)
            Me.changeListLevelToolStripMenuItem.Name = "changeListLevelToolStripMenuItem"
            Me.changeListLevelToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
            Me.changeListLevelToolStripMenuItem.Text = "&Change List Level"
            '
            'defineNewBulletToolStripMenuItem
            '
            Me.defineNewBulletToolStripMenuItem.Name = "defineNewBulletToolStripMenuItem"
            Me.defineNewBulletToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
            Me.defineNewBulletToolStripMenuItem.Text = "&Define New Bullet..."
            '
            'numberingToolStripSplitBtn
            '
            Me.superAccelerator.SetAccelerator(Me.numberingToolStripSplitBtn, "N")
            Me.numberingToolStripSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.numberingToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.changeListLevelToolStripMenuItem1, Me.defineNewNumberFormatToolStripMenuItem, Me.setNumberingValueToolStripMenuItem})
            Me.numberingToolStripSplitBtn.Image = CType(resources.GetObject("numberingToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.numberingToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.numberingToolStripSplitBtn.Name = "numberingToolStripSplitBtn"
            Me.numberingToolStripSplitBtn.Size = New System.Drawing.Size(32, 20)
            Me.numberingToolStripSplitBtn.Text = "numberingToolStripSplitBtn"
            ToolTipInfo60.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo60.Body.Text = "Start a numbered list."
            ToolTipInfo60.Body.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ToolTipInfo60.Footer.Hidden = True
            ToolTipInfo60.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo60.Header.Text = "Numbering"
            ToolTipInfo60.Separator = False
            Me.superToolTip1.SetToolTip(Me.numberingToolStripSplitBtn, ToolTipInfo60)
            '
            'changeListLevelToolStripMenuItem1
            '
            Me.changeListLevelToolStripMenuItem1.Image = CType(resources.GetObject("changeListLevelToolStripMenuItem1.Image"), System.Drawing.Image)
            Me.changeListLevelToolStripMenuItem1.Name = "changeListLevelToolStripMenuItem1"
            Me.changeListLevelToolStripMenuItem1.Size = New System.Drawing.Size(229, 22)
            Me.changeListLevelToolStripMenuItem1.Text = "&Change List Level"
            '
            'defineNewNumberFormatToolStripMenuItem
            '
            Me.defineNewNumberFormatToolStripMenuItem.Name = "defineNewNumberFormatToolStripMenuItem"
            Me.defineNewNumberFormatToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
            Me.defineNewNumberFormatToolStripMenuItem.Text = "&Define New Number Format..."
            '
            'setNumberingValueToolStripMenuItem
            '
            Me.setNumberingValueToolStripMenuItem.Image = CType(resources.GetObject("setNumberingValueToolStripMenuItem.Image"), System.Drawing.Image)
            Me.setNumberingValueToolStripMenuItem.Name = "setNumberingValueToolStripMenuItem"
            Me.setNumberingValueToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
            Me.setNumberingValueToolStripMenuItem.Text = "Set Numbering &Value..."
            '
            'multilevelToolStripSplitBtn
            '
            Me.superAccelerator.SetAccelerator(Me.multilevelToolStripSplitBtn, "M")
            Me.multilevelToolStripSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.multilevelToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.changeListLevelToolStripMenuItem2, Me.defineNewMultilevelListToolStripMenuItem, Me.defineNewListStyleToolStripMenuItem})
            Me.multilevelToolStripSplitBtn.Image = CType(resources.GetObject("multilevelToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.multilevelToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.multilevelToolStripSplitBtn.Name = "multilevelToolStripSplitBtn"
            Me.multilevelToolStripSplitBtn.Size = New System.Drawing.Size(32, 20)
            Me.multilevelToolStripSplitBtn.Text = "multilevelToolStripSplitBtn"
            ToolTipInfo61.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo61.Body.Text = "Start a multilevel list."
            ToolTipInfo61.Body.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ToolTipInfo61.Footer.Hidden = True
            ToolTipInfo61.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo61.Header.Text = "Multilevel List"
            ToolTipInfo61.Separator = False
            Me.superToolTip1.SetToolTip(Me.multilevelToolStripSplitBtn, ToolTipInfo61)
            '
            'changeListLevelToolStripMenuItem2
            '
            Me.changeListLevelToolStripMenuItem2.Image = CType(resources.GetObject("changeListLevelToolStripMenuItem2.Image"), System.Drawing.Image)
            Me.changeListLevelToolStripMenuItem2.Name = "changeListLevelToolStripMenuItem2"
            Me.changeListLevelToolStripMenuItem2.Size = New System.Drawing.Size(218, 22)
            Me.changeListLevelToolStripMenuItem2.Text = "&Change List Level"
            '
            'defineNewMultilevelListToolStripMenuItem
            '
            Me.defineNewMultilevelListToolStripMenuItem.Name = "defineNewMultilevelListToolStripMenuItem"
            Me.defineNewMultilevelListToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
            Me.defineNewMultilevelListToolStripMenuItem.Text = "&Define New Multilevel List..."
            '
            'defineNewListStyleToolStripMenuItem
            '
            Me.defineNewListStyleToolStripMenuItem.Name = "defineNewListStyleToolStripMenuItem"
            Me.defineNewListStyleToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
            Me.defineNewListStyleToolStripMenuItem.Text = "Define New &List Style..."
            '
            'toolStripPanelItem8
            '
            Me.toolStripPanelItem8.CausesValidation = False
            Me.toolStripPanelItem8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem8.GroupedButtons = True
            Me.toolStripPanelItem8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.deindentToolStripBtn, Me.inindentToolStripBtn})
            Me.toolStripPanelItem8.Name = "toolStripPanelItem8"
            Me.toolStripPanelItem8.RowCount = 1
            Me.toolStripPanelItem8.Size = New System.Drawing.Size(50, 27)
            Me.toolStripPanelItem8.Text = "toolStripPanelItem8"
            Me.toolStripPanelItem8.Transparent = True
            '
            'deindentToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.deindentToolStripBtn, "AO")
            Me.deindentToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.deindentToolStripBtn.Image = CType(resources.GetObject("deindentToolStripBtn.Image"), System.Drawing.Image)
            Me.deindentToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.deindentToolStripBtn.Name = "deindentToolStripBtn"
            Me.deindentToolStripBtn.Size = New System.Drawing.Size(23, 20)
            Me.deindentToolStripBtn.Text = "deindentToolStripBtn"
            ToolTipInfo62.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo62.Body.Text = "Decreases the indent level of the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "paragraph."
            ToolTipInfo62.Body.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ToolTipInfo62.Footer.Hidden = True
            ToolTipInfo62.ForeColor = System.Drawing.SystemColors.ControlText
            ToolTipInfo62.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo62.Header.Text = "Decrease Indent"
            ToolTipInfo62.Separator = False
            Me.superToolTip1.SetToolTip(Me.deindentToolStripBtn, ToolTipInfo62)
            '
            'inindentToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.inindentToolStripBtn, "AI")
            Me.inindentToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.inindentToolStripBtn.Image = CType(resources.GetObject("inindentToolStripBtn.Image"), System.Drawing.Image)
            Me.inindentToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.inindentToolStripBtn.Name = "inindentToolStripBtn"
            Me.inindentToolStripBtn.Size = New System.Drawing.Size(23, 20)
            Me.inindentToolStripBtn.Text = "inindentToolStripBtn"
            ToolTipInfo63.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo63.Body.Text = "Increase the indent level of the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "paragraph."
            ToolTipInfo63.Body.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ToolTipInfo63.Footer.Hidden = True
            ToolTipInfo63.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo63.Header.Text = "Increase Indent"
            ToolTipInfo63.Separator = False
            Me.superToolTip1.SetToolTip(Me.inindentToolStripBtn, ToolTipInfo63)
            '
            'toolStripPanelItem9
            '
            Me.toolStripPanelItem9.CausesValidation = False
            Me.toolStripPanelItem9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem9.GroupedButtons = True
            Me.toolStripPanelItem9.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sortToolStripBtn})
            Me.toolStripPanelItem9.Name = "toolStripPanelItem9"
            Me.toolStripPanelItem9.RowCount = 1
            Me.toolStripPanelItem9.Size = New System.Drawing.Size(27, 27)
            Me.toolStripPanelItem9.Text = "toolStripPanelItem9"
            Me.toolStripPanelItem9.Transparent = True
            '
            'sortToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.sortToolStripBtn, "SO")
            Me.sortToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.sortToolStripBtn.Image = CType(resources.GetObject("sortToolStripBtn.Image"), System.Drawing.Image)
            Me.sortToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.sortToolStripBtn.Name = "sortToolStripBtn"
            Me.sortToolStripBtn.Size = New System.Drawing.Size(23, 20)
            Me.sortToolStripBtn.Text = "sortToolStripBtn"
            ToolTipInfo64.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo64.Body.Text = "Alphabetize the selected text or" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sort numerical data."
            ToolTipInfo64.Body.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            ToolTipInfo64.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo64.Footer.Hidden = True
            ToolTipInfo64.Footer.ImageScalingSize = New System.Drawing.Size(16, 16)
            ToolTipInfo64.Footer.Text = ""
            ToolTipInfo64.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo64.Header.Text = "Sort"
            ToolTipInfo64.Separator = False
            Me.superToolTip1.SetToolTip(Me.sortToolStripBtn, ToolTipInfo64)
            '
            'lAlignToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.lAlignToolStripBtn, "AL")
            Me.lAlignToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.lAlignToolStripBtn.Image = CType(resources.GetObject("lAlignToolStripBtn.Image"), System.Drawing.Image)
            Me.lAlignToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.lAlignToolStripBtn.Name = "lAlignToolStripBtn"
            Me.SetShortcut(Me.lAlignToolStripBtn, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys))
            Me.lAlignToolStripBtn.Size = New System.Drawing.Size(23, 20)
            Me.lAlignToolStripBtn.Text = "lAlignToolStripBtn"
            ToolTipInfo65.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo65.Body.Text = "Align text to the left."
            ToolTipInfo65.Body.TextMargin = New System.Windows.Forms.Padding(5, 0, 0, 0)
            ToolTipInfo65.Footer.Hidden = True
            ToolTipInfo65.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo65.Header.Text = "Align Text Left"
            ToolTipInfo65.Separator = False
            Me.superToolTip1.SetToolTip(Me.lAlignToolStripBtn, ToolTipInfo65)
            '
            'centerToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.centerToolStripBtn, "AC")
            Me.centerToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.centerToolStripBtn.Image = CType(resources.GetObject("centerToolStripBtn.Image"), System.Drawing.Image)
            Me.centerToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.centerToolStripBtn.Name = "centerToolStripBtn"
            Me.SetShortcut(Me.centerToolStripBtn, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys))
            Me.centerToolStripBtn.Size = New System.Drawing.Size(23, 20)
            Me.centerToolStripBtn.Text = "centerToolStripBtn"
            ToolTipInfo66.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo66.Body.Text = "Center text."
            ToolTipInfo66.Body.TextMargin = New System.Windows.Forms.Padding(10, 0, 5, 0)
            ToolTipInfo66.Footer.Hidden = True
            ToolTipInfo66.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo66.Header.Text = "Center"
            ToolTipInfo66.Separator = False
            Me.superToolTip1.SetToolTip(Me.centerToolStripBtn, ToolTipInfo66)
            '
            'rAlignToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.rAlignToolStripBtn, "AR")
            Me.rAlignToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.rAlignToolStripBtn.Image = CType(resources.GetObject("rAlignToolStripBtn.Image"), System.Drawing.Image)
            Me.rAlignToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.rAlignToolStripBtn.Name = "rAlignToolStripBtn"
            Me.SetShortcut(Me.rAlignToolStripBtn, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys))
            Me.rAlignToolStripBtn.Size = New System.Drawing.Size(23, 20)
            Me.rAlignToolStripBtn.Text = "rAlignToolStripBtn"
            ToolTipInfo67.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo67.Body.Text = "Align text to the right."
            ToolTipInfo67.Body.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ToolTipInfo67.Footer.Hidden = True
            ToolTipInfo67.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo67.Header.Text = "Align Text Right"
            ToolTipInfo67.Separator = False
            Me.superToolTip1.SetToolTip(Me.rAlignToolStripBtn, ToolTipInfo67)
            '
            'justifyToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.justifyToolStripBtn, "AJ")
            Me.justifyToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.justifyToolStripBtn.Image = CType(resources.GetObject("justifyToolStripBtn.Image"), System.Drawing.Image)
            Me.justifyToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.justifyToolStripBtn.Name = "justifyToolStripBtn"
            Me.SetShortcut(Me.justifyToolStripBtn, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys))
            Me.justifyToolStripBtn.Size = New System.Drawing.Size(23, 20)
            Me.justifyToolStripBtn.Text = "toolStripButton21"
            ToolTipInfo68.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo68.Body.Text = "Align text to both the left and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "right margins, adding extra space" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "between word" & _
                "s as necessary."
            ToolTipInfo68.Body.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            ToolTipInfo68.Footer.Text = "This creates a clean look along the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "left and right side of the page."
            ToolTipInfo68.Footer.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            ToolTipInfo68.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo68.Header.Text = "Justify"
            ToolTipInfo68.Separator = False
            Me.superToolTip1.SetToolTip(Me.justifyToolStripBtn, ToolTipInfo68)
            '
            'lspacingToolStripDropDwnBtn
            '
            Me.superAccelerator.SetAccelerator(Me.lspacingToolStripDropDwnBtn, "K")
            Me.lspacingToolStripDropDwnBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.lspacingToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem2, Me.toolStripMenuItem3, Me.toolStripMenuItem4, Me.toolStripMenuItem5, Me.toolStripMenuItem6, Me.toolStripMenuItem7, Me.moreToolStripMenuItem, Me.toolStripSeparator9, Me.addSpaceBeforeParagraphToolStripMenuItem, Me.removeSpaceAfterParagraphToolStripMenuItem})
            Me.lspacingToolStripDropDwnBtn.Image = CType(resources.GetObject("lspacingToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.lspacingToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.White
            Me.lspacingToolStripDropDwnBtn.Name = "lspacingToolStripDropDwnBtn"
            Me.lspacingToolStripDropDwnBtn.Size = New System.Drawing.Size(29, 20)
            Me.lspacingToolStripDropDwnBtn.Text = "lspacingToolStripDropDwnBtn"
            ToolTipInfo69.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo69.Body.Text = "Change the spacing between lines" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of text."
            ToolTipInfo69.Body.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ToolTipInfo69.Footer.Hidden = True
            ToolTipInfo69.ForeColor = System.Drawing.SystemColors.ControlText
            ToolTipInfo69.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo69.Header.Text = "Line Spacing"
            ToolTipInfo69.Separator = False
            Me.superToolTip1.SetToolTip(Me.lspacingToolStripDropDwnBtn, ToolTipInfo69)
            '
            'toolStripMenuItem2
            '
            Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
            Me.toolStripMenuItem2.Size = New System.Drawing.Size(237, 22)
            Me.toolStripMenuItem2.Text = "1.0"
            '
            'toolStripMenuItem3
            '
            Me.toolStripMenuItem3.Checked = True
            Me.toolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked
            Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
            Me.toolStripMenuItem3.Size = New System.Drawing.Size(237, 22)
            Me.toolStripMenuItem3.Text = "1.15"
            '
            'toolStripMenuItem4
            '
            Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
            Me.toolStripMenuItem4.Size = New System.Drawing.Size(237, 22)
            Me.toolStripMenuItem4.Text = "1.5"
            '
            'toolStripMenuItem5
            '
            Me.toolStripMenuItem5.Name = "toolStripMenuItem5"
            Me.toolStripMenuItem5.Size = New System.Drawing.Size(237, 22)
            Me.toolStripMenuItem5.Text = "2.0"
            '
            'toolStripMenuItem6
            '
            Me.toolStripMenuItem6.Name = "toolStripMenuItem6"
            Me.toolStripMenuItem6.Size = New System.Drawing.Size(237, 22)
            Me.toolStripMenuItem6.Text = "2.5"
            '
            'toolStripMenuItem7
            '
            Me.toolStripMenuItem7.Name = "toolStripMenuItem7"
            Me.toolStripMenuItem7.Size = New System.Drawing.Size(237, 22)
            Me.toolStripMenuItem7.Text = "3.0"
            '
            'moreToolStripMenuItem
            '
            Me.moreToolStripMenuItem.Name = "moreToolStripMenuItem"
            Me.moreToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
            Me.moreToolStripMenuItem.Text = "More..."
            '
            'toolStripSeparator9
            '
            Me.toolStripSeparator9.Name = "toolStripSeparator9"
            Me.toolStripSeparator9.Size = New System.Drawing.Size(234, 6)
            '
            'addSpaceBeforeParagraphToolStripMenuItem
            '
            Me.addSpaceBeforeParagraphToolStripMenuItem.Image = CType(resources.GetObject("addSpaceBeforeParagraphToolStripMenuItem.Image"), System.Drawing.Image)
            Me.addSpaceBeforeParagraphToolStripMenuItem.Name = "addSpaceBeforeParagraphToolStripMenuItem"
            Me.addSpaceBeforeParagraphToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
            Me.addSpaceBeforeParagraphToolStripMenuItem.Text = "&Add Space Before Paragraph"
            '
            'removeSpaceAfterParagraphToolStripMenuItem
            '
            Me.removeSpaceAfterParagraphToolStripMenuItem.Image = CType(resources.GetObject("removeSpaceAfterParagraphToolStripMenuItem.Image"), System.Drawing.Image)
            Me.removeSpaceAfterParagraphToolStripMenuItem.Name = "removeSpaceAfterParagraphToolStripMenuItem"
            Me.removeSpaceAfterParagraphToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
            Me.removeSpaceAfterParagraphToolStripMenuItem.Text = "&Remove Space After Paragraph"
            Me.statusStripButton1.StatusString = "chack"
            '
            'shadingToolStripSplitBtn
            '
            Me.superAccelerator.SetAccelerator(Me.shadingToolStripSplitBtn, "H")
            Me.shadingToolStripSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.shadingToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.noColorToolStripMenuItem1, Me.toolStripSeparator10, Me.moreShadingColorsToolStripMenuItem})
            Me.shadingToolStripSplitBtn.Image = CType(resources.GetObject("shadingToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.shadingToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.shadingToolStripSplitBtn.Name = "shadingToolStripSplitBtn"
            Me.shadingToolStripSplitBtn.Size = New System.Drawing.Size(32, 20)
            Me.shadingToolStripSplitBtn.Text = "shadingToolStripSplitBtn"
            ToolTipInfo70.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo70.Body.Text = "Color the background behind the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "selected text or paragraph."
            ToolTipInfo70.Body.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ToolTipInfo70.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo70.Footer.Hidden = True
            ToolTipInfo70.Footer.ImageScalingSize = New System.Drawing.Size(16, 16)
            ToolTipInfo70.Footer.Text = ""
            ToolTipInfo70.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo70.Header.Text = "Shading"
            ToolTipInfo70.Separator = False
            Me.superToolTip1.SetToolTip(Me.shadingToolStripSplitBtn, ToolTipInfo70)
            '
            'noColorToolStripMenuItem1
            '
            Me.noColorToolStripMenuItem1.Image = CType(resources.GetObject("noColorToolStripMenuItem1.Image"), System.Drawing.Image)
            Me.noColorToolStripMenuItem1.Name = "noColorToolStripMenuItem1"
            Me.noColorToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
            Me.noColorToolStripMenuItem1.Text = "&No Color"
            '
            'toolStripSeparator10
            '
            Me.toolStripSeparator10.Name = "toolStripSeparator10"
            Me.toolStripSeparator10.Size = New System.Drawing.Size(192, 6)
            '
            'moreShadingColorsToolStripMenuItem
            '
            Me.moreShadingColorsToolStripMenuItem.Image = CType(resources.GetObject("moreShadingColorsToolStripMenuItem.Image"), System.Drawing.Image)
            Me.moreShadingColorsToolStripMenuItem.Name = "moreShadingColorsToolStripMenuItem"
            Me.moreShadingColorsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
            Me.moreShadingColorsToolStripMenuItem.Text = "&More Shading Colors..."
            '
            'btmborderToolStripSplitBtn
            '
            Me.superAccelerator.SetAccelerator(Me.btmborderToolStripSplitBtn, "B")
            Me.btmborderToolStripSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btmborderToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bottomBorderToolStripMenuItem, Me.topBoToolStripMenuItem, Me.leftBorderToolStripMenuItem, Me.rightBorderToolStripMenuItem, Me.toolStripSeparator1, Me.noBorderToolStripMenuItem, Me.allBordersToolStripMenuItem, Me.outsideBordersToolStripMenuItem, Me.insideBordersToolStripMenuItem, Me.toolStripSeparator2, Me.insideHorizontalBorderToolStripMenuItem, Me.insideVerticalBorderToolStripMenuItem, Me.diagonalDownBorderToolStripMenuItem, Me.diagonalUpBorderToolStripMenuItem, Me.toolStripSeparator3, Me.horizontalLineToolStripMenuItem, Me.toolStripSeparator4, Me.showGridlinesToolStripMenuItem, Me.bordersAndShadingToolStripMenuItem})
            Me.btmborderToolStripSplitBtn.Image = CType(resources.GetObject("btmborderToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.btmborderToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btmborderToolStripSplitBtn.Name = "btmborderToolStripSplitBtn"
            Me.btmborderToolStripSplitBtn.Size = New System.Drawing.Size(32, 20)
            Me.btmborderToolStripSplitBtn.Text = "btmborderToolStripSplitBtn"
            ToolTipInfo71.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo71.Body.Text = "Customize the borders of the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "selected text or cells."
            ToolTipInfo71.Body.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ToolTipInfo71.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo71.Footer.Hidden = True
            ToolTipInfo71.Footer.ImageScalingSize = New System.Drawing.Size(16, 16)
            ToolTipInfo71.Footer.Text = "Press F1 for more help."
            ToolTipInfo71.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo71.Header.Text = "Bottom Border"
            ToolTipInfo71.Separator = False
            Me.superToolTip1.SetToolTip(Me.btmborderToolStripSplitBtn, ToolTipInfo71)
            '
            'bottomBorderToolStripMenuItem
            '
            Me.bottomBorderToolStripMenuItem.Image = CType(resources.GetObject("bottomBorderToolStripMenuItem.Image"), System.Drawing.Image)
            Me.bottomBorderToolStripMenuItem.Name = "bottomBorderToolStripMenuItem"
            Me.bottomBorderToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
            Me.bottomBorderToolStripMenuItem.Text = "&Bottom Border"
            '
            'topBoToolStripMenuItem
            '
            Me.topBoToolStripMenuItem.Image = CType(resources.GetObject("topBoToolStripMenuItem.Image"), System.Drawing.Image)
            Me.topBoToolStripMenuItem.Name = "topBoToolStripMenuItem"
            Me.topBoToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
            Me.topBoToolStripMenuItem.Text = "To&p Border"
            '
            'leftBorderToolStripMenuItem
            '
            Me.leftBorderToolStripMenuItem.Image = CType(resources.GetObject("leftBorderToolStripMenuItem.Image"), System.Drawing.Image)
            Me.leftBorderToolStripMenuItem.Name = "leftBorderToolStripMenuItem"
            Me.leftBorderToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
            Me.leftBorderToolStripMenuItem.Text = "&Left Border"
            '
            'rightBorderToolStripMenuItem
            '
            Me.rightBorderToolStripMenuItem.Image = CType(resources.GetObject("rightBorderToolStripMenuItem.Image"), System.Drawing.Image)
            Me.rightBorderToolStripMenuItem.Name = "rightBorderToolStripMenuItem"
            Me.rightBorderToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
            Me.rightBorderToolStripMenuItem.Text = "&Right Border"
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(197, 6)
            '
            'noBorderToolStripMenuItem
            '
            Me.noBorderToolStripMenuItem.Image = CType(resources.GetObject("noBorderToolStripMenuItem.Image"), System.Drawing.Image)
            Me.noBorderToolStripMenuItem.Name = "noBorderToolStripMenuItem"
            Me.noBorderToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
            Me.noBorderToolStripMenuItem.Text = "&No Border"
            '
            'allBordersToolStripMenuItem
            '
            Me.allBordersToolStripMenuItem.Image = CType(resources.GetObject("allBordersToolStripMenuItem.Image"), System.Drawing.Image)
            Me.allBordersToolStripMenuItem.Name = "allBordersToolStripMenuItem"
            Me.allBordersToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
            Me.allBordersToolStripMenuItem.Text = "&All Borders"
            '
            'outsideBordersToolStripMenuItem
            '
            Me.outsideBordersToolStripMenuItem.Image = CType(resources.GetObject("outsideBordersToolStripMenuItem.Image"), System.Drawing.Image)
            Me.outsideBordersToolStripMenuItem.Name = "outsideBordersToolStripMenuItem"
            Me.outsideBordersToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
            Me.outsideBordersToolStripMenuItem.Text = "Out&side Borders"
            '
            'insideBordersToolStripMenuItem
            '
            Me.insideBordersToolStripMenuItem.Image = CType(resources.GetObject("insideBordersToolStripMenuItem.Image"), System.Drawing.Image)
            Me.insideBordersToolStripMenuItem.Name = "insideBordersToolStripMenuItem"
            Me.insideBordersToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
            Me.insideBordersToolStripMenuItem.Text = "&Inside Borders"
            '
            'toolStripSeparator2
            '
            Me.toolStripSeparator2.Name = "toolStripSeparator2"
            Me.toolStripSeparator2.Size = New System.Drawing.Size(197, 6)
            '
            'insideHorizontalBorderToolStripMenuItem
            '
            Me.insideHorizontalBorderToolStripMenuItem.Image = CType(resources.GetObject("insideHorizontalBorderToolStripMenuItem.Image"), System.Drawing.Image)
            Me.insideHorizontalBorderToolStripMenuItem.Name = "insideHorizontalBorderToolStripMenuItem"
            Me.insideHorizontalBorderToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
            Me.insideHorizontalBorderToolStripMenuItem.Text = "Inside &Horizontal Border"
            '
            'insideVerticalBorderToolStripMenuItem
            '
            Me.insideVerticalBorderToolStripMenuItem.Image = CType(resources.GetObject("insideVerticalBorderToolStripMenuItem.Image"), System.Drawing.Image)
            Me.insideVerticalBorderToolStripMenuItem.Name = "insideVerticalBorderToolStripMenuItem"
            Me.insideVerticalBorderToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
            Me.insideVerticalBorderToolStripMenuItem.Text = "Inside &Vertical Border"
            '
            'diagonalDownBorderToolStripMenuItem
            '
            Me.diagonalDownBorderToolStripMenuItem.Enabled = False
            Me.diagonalDownBorderToolStripMenuItem.Image = CType(resources.GetObject("diagonalDownBorderToolStripMenuItem.Image"), System.Drawing.Image)
            Me.diagonalDownBorderToolStripMenuItem.Name = "diagonalDownBorderToolStripMenuItem"
            Me.diagonalDownBorderToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
            Me.diagonalDownBorderToolStripMenuItem.Text = "&Diagonal Down Border"
            '
            'diagonalUpBorderToolStripMenuItem
            '
            Me.diagonalUpBorderToolStripMenuItem.Enabled = False
            Me.diagonalUpBorderToolStripMenuItem.Image = CType(resources.GetObject("diagonalUpBorderToolStripMenuItem.Image"), System.Drawing.Image)
            Me.diagonalUpBorderToolStripMenuItem.Name = "diagonalUpBorderToolStripMenuItem"
            Me.diagonalUpBorderToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
            Me.diagonalUpBorderToolStripMenuItem.Text = "Diagonal &Up Border"
            '
            'toolStripSeparator3
            '
            Me.toolStripSeparator3.Name = "toolStripSeparator3"
            Me.toolStripSeparator3.Size = New System.Drawing.Size(197, 6)
            '
            'horizontalLineToolStripMenuItem
            '
            Me.horizontalLineToolStripMenuItem.Image = CType(resources.GetObject("horizontalLineToolStripMenuItem.Image"), System.Drawing.Image)
            Me.horizontalLineToolStripMenuItem.Name = "horizontalLineToolStripMenuItem"
            Me.horizontalLineToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
            Me.horizontalLineToolStripMenuItem.Text = "Hori&zontal Line"
            '
            'toolStripSeparator4
            '
            Me.toolStripSeparator4.Name = "toolStripSeparator4"
            Me.toolStripSeparator4.Size = New System.Drawing.Size(197, 6)
            '
            'showGridlinesToolStripMenuItem
            '
            Me.showGridlinesToolStripMenuItem.Image = CType(resources.GetObject("showGridlinesToolStripMenuItem.Image"), System.Drawing.Image)
            Me.showGridlinesToolStripMenuItem.Name = "showGridlinesToolStripMenuItem"
            Me.showGridlinesToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
            Me.showGridlinesToolStripMenuItem.Text = "Show &Gridlines"
            '
            'bordersAndShadingToolStripMenuItem
            '
            Me.bordersAndShadingToolStripMenuItem.Image = CType(resources.GetObject("bordersAndShadingToolStripMenuItem.Image"), System.Drawing.Image)
            Me.bordersAndShadingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.bordersAndShadingToolStripMenuItem.Name = "bordersAndShadingToolStripMenuItem"
            Me.bordersAndShadingToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
            Me.bordersAndShadingToolStripMenuItem.Text = "Border&s and Shading..."
            '
            'stylesToolStripExt
            '
			Me.stylesToolStripExt.AutoSize = False
            Me.stylesToolStripExt.CollapsedDropDownButtonText = "Styles"
            Me.stylesToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.stylesToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.stylesToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.stylesToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.stylesToolStripExt.Image = CType(resources.GetObject("stylesToolStripExt.Image"), System.Drawing.Image)
            Me.stylesToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripGallery2, Me.qckstylesToolStripDropDwnBtn})
            Me.stylesToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
            Me.stylesToolStripExt.Location = New System.Drawing.Point(561, 1)
            Me.stylesToolStripExt.Name = "stylesToolStripExt"
            Me.stylesToolStripExt.Size = New System.Drawing.Size(330, 88)
            Me.stylesToolStripExt.TabIndex = 3
            Me.stylesToolStripExt.Text = "Styles"
            '
            'toolStripGallery2
            '
            Me.toolStripGallery2.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolstripGalleryBorderStyle.None
            Me.toolStripGallery2.CaptionText = ""
            Me.toolStripGallery2.Dimensions = New System.Drawing.Size(0, 0)
            Me.toolStripGallery2.ImageList = Me.GalleryImages
            Me.toolStripGallery2.ItemBackColor = System.Drawing.Color.Empty
            Me.toolStripGallery2.ItemImageSize = New System.Drawing.Size(70, 50)
            ToolStripGalleryItem1.ImageIndex = 0
            ToolStripGalleryItem1.Tag = "H1"
            ToolStripGalleryItem1.Text = "Heading 1"
            ToolStripGalleryItem2.ImageIndex = 1
            ToolStripGalleryItem2.Tag = "H2"
            ToolStripGalleryItem2.Text = "Heading 2"
            ToolStripGalleryItem3.ImageIndex = 2
            ToolStripGalleryItem3.Tag = "H3"
            ToolStripGalleryItem3.Text = "Heading 3"
            ToolStripGalleryItem4.ImageIndex = 3
            ToolStripGalleryItem4.Tag = "H4"
            ToolStripGalleryItem4.Text = "Heading 4"
            ToolStripGalleryItem5.ImageIndex = 4
            ToolStripGalleryItem5.Tag = "H5"
            ToolStripGalleryItem5.Text = "Heading 5"
            ToolStripGalleryItem6.ImageIndex = 5
            ToolStripGalleryItem6.Tag = "H6"
            ToolStripGalleryItem6.Text = "Heading 6"
            ToolStripGalleryItem7.ImageIndex = 6
            ToolStripGalleryItem7.Tag = "H7"
            ToolStripGalleryItem7.Text = "Heading 7"
            ToolStripGalleryItem8.ImageIndex = 7
            ToolStripGalleryItem8.Tag = "H8"
            ToolStripGalleryItem8.Text = "Heading 8"
            ToolStripGalleryItem9.ImageIndex = 8
            ToolStripGalleryItem9.Tag = "H9"
            ToolStripGalleryItem9.Text = "Heading 9"
            Me.toolStripGallery2.Items.Add(ToolStripGalleryItem1)
            Me.toolStripGallery2.Items.Add(ToolStripGalleryItem2)
            Me.toolStripGallery2.Items.Add(ToolStripGalleryItem3)
            Me.toolStripGallery2.Items.Add(ToolStripGalleryItem4)
            Me.toolStripGallery2.Items.Add(ToolStripGalleryItem5)
            Me.toolStripGallery2.Items.Add(ToolStripGalleryItem6)
            Me.toolStripGallery2.Items.Add(ToolStripGalleryItem7)
            Me.toolStripGallery2.Items.Add(ToolStripGalleryItem8)
            Me.toolStripGallery2.Items.Add(ToolStripGalleryItem9)
            Me.toolStripGallery2.ItemSize = New System.Drawing.Size(78, 62)
            Me.toolStripGallery2.Name = "toolStripGallery2"
            Me.toolStripGallery2.ScrollerType = Syncfusion.Windows.Forms.Tools.ToolStripGalleryScrollerType.Compact
            Me.toolStripGallery2.Size = New System.Drawing.Size(255, 64)
            Me.toolStripGallery2.Text = "toolStripGallery2"
            '
            'GalleryImages
            '
            Me.GalleryImages.ImageStream = CType(resources.GetObject("GalleryImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.GalleryImages.TransparentColor = System.Drawing.Color.Transparent
            Me.GalleryImages.Images.SetKeyName(0, "2.png")
            Me.GalleryImages.Images.SetKeyName(1, "3.png")
            Me.GalleryImages.Images.SetKeyName(2, "1.png")
            Me.GalleryImages.Images.SetKeyName(3, "4.png")
            Me.GalleryImages.Images.SetKeyName(4, "5.png")
            Me.GalleryImages.Images.SetKeyName(5, "6.png")
            Me.GalleryImages.Images.SetKeyName(6, "7.png")
            Me.GalleryImages.Images.SetKeyName(7, "8.png")
            Me.GalleryImages.Images.SetKeyName(8, "9.png")
            '
            'qckstylesToolStripDropDwnBtn
            '
            Me.superAccelerator.SetAccelerator(Me.qckstylesToolStripDropDwnBtn, "L")
            Me.qckstylesToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.blueToolStripMenuItem, Me.silverToolStripMenuItem, Me.blackToolStripMenuItem})
            Me.qckstylesToolStripDropDwnBtn.Image = CType(resources.GetObject("qckstylesToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.qckstylesToolStripDropDwnBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.qckstylesToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.qckstylesToolStripDropDwnBtn.Name = "qckstylesToolStripDropDwnBtn"
            Me.qckstylesToolStripDropDwnBtn.Size = New System.Drawing.Size(49, 67)
            Me.qckstylesToolStripDropDwnBtn.Text = "Quick " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Styles"
            Me.qckstylesToolStripDropDwnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo72.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo72.Body.Text = "Use supported Styles"
            ToolTipInfo72.Body.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            ToolTipInfo72.Footer.Hidden = True
            ToolTipInfo72.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo72.Header.Text = "Quick Styles"
            ToolTipInfo72.Separator = False
            Me.superToolTip1.SetToolTip(Me.qckstylesToolStripDropDwnBtn, ToolTipInfo72)
            '
            'blueToolStripMenuItem
            '
            Me.blueToolStripMenuItem.Checked = True
            Me.blueToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.blueToolStripMenuItem.Name = "blueToolStripMenuItem"
            Me.blueToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
            Me.blueToolStripMenuItem.Text = "&Blue"
            '
            'silverToolStripMenuItem
            '
            Me.silverToolStripMenuItem.Name = "silverToolStripMenuItem"
            Me.silverToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
            Me.silverToolStripMenuItem.Text = "&Silver"
            '
            'blackToolStripMenuItem
            '
            Me.blackToolStripMenuItem.Name = "blackToolStripMenuItem"
            Me.blackToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
            Me.blackToolStripMenuItem.Text = "Bl&ack"
            '
            'editingToolStripExt
            '
			Me.editingToolStripExt.AutoSize = False
            Me.editingToolStripExt.CollapsedDropDownButtonText = "Editing"
            Me.editingToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.editingToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.editingToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.editingToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.editingToolStripExt.Image = CType(resources.GetObject("editingToolStripExt.Image"), System.Drawing.Image)
            Me.editingToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem10})
            Me.editingToolStripExt.Location = New System.Drawing.Point(891, 1)
            Me.editingToolStripExt.Name = "editingToolStripExt"
            Me.editingToolStripExt.ShowLauncher = False
            Me.editingToolStripExt.Size = New System.Drawing.Size(94, 88)
            Me.editingToolStripExt.TabIndex = 4
            Me.editingToolStripExt.Text = "Editing"
            '
            'toolStripPanelItem10
            '
            Me.toolStripPanelItem10.CausesValidation = False
            Me.toolStripPanelItem10.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem10.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.findToolStripBtn, Me.replaceToolStripBtn, Me.selectToolStripDropDwnBtn})
            Me.toolStripPanelItem10.Name = "toolStripPanelItem10"
            Me.toolStripPanelItem10.Size = New System.Drawing.Size(69, 71)
            Me.toolStripPanelItem10.Text = "toolStripPanelItem10"
            Me.toolStripPanelItem10.Transparent = True
            '
            'findToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.findToolStripBtn, "FD")
            Me.findToolStripBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.findToolStripMenuItem, Me.goToToolStripMenuItem})
            Me.findToolStripBtn.Image = CType(resources.GetObject("findToolStripBtn.Image"), System.Drawing.Image)
            Me.findToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.findToolStripBtn.Name = "findToolStripBtn"
            Me.SetShortcut(Me.findToolStripBtn, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys))
            Me.findToolStripBtn.Size = New System.Drawing.Size(59, 20)
            Me.findToolStripBtn.Text = "Find"
            ToolTipInfo73.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo73.Body.Text = "Find text in the document."
            ToolTipInfo73.Body.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ToolTipInfo73.Footer.Hidden = True
            ToolTipInfo73.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo73.Header.Text = "Find"
            ToolTipInfo73.Separator = False
            Me.superToolTip1.SetToolTip(Me.findToolStripBtn, ToolTipInfo73)
            '
            'findToolStripMenuItem
            '
            Me.findToolStripMenuItem.Image = CType(resources.GetObject("findToolStripMenuItem.Image"), System.Drawing.Image)
            Me.findToolStripMenuItem.Name = "findToolStripMenuItem"
            Me.findToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
            Me.findToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
            Me.findToolStripMenuItem.Text = "&Find..."
            '
            'goToToolStripMenuItem
            '
            Me.goToToolStripMenuItem.Image = CType(resources.GetObject("goToToolStripMenuItem.Image"), System.Drawing.Image)
            Me.goToToolStripMenuItem.Name = "goToToolStripMenuItem"
            Me.goToToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
            Me.goToToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
            Me.goToToolStripMenuItem.Text = "&Go To..."
            '
            'replaceToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.replaceToolStripBtn, "R")
            Me.replaceToolStripBtn.Image = CType(resources.GetObject("replaceToolStripBtn.Image"), System.Drawing.Image)
            Me.replaceToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.replaceToolStripBtn.Name = "replaceToolStripBtn"
            Me.SetShortcut(Me.replaceToolStripBtn, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys))
            Me.replaceToolStripBtn.Size = New System.Drawing.Size(65, 20)
            Me.replaceToolStripBtn.Text = "Replace"
            ToolTipInfo74.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo74.Body.Text = "Replace text in the document."
            ToolTipInfo74.Body.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ToolTipInfo74.Footer.Hidden = True
            ToolTipInfo74.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo74.Header.Text = "Replace"
            ToolTipInfo74.Separator = False
            Me.superToolTip1.SetToolTip(Me.replaceToolStripBtn, ToolTipInfo74)
            '
            'selectToolStripDropDwnBtn
            '
            Me.superAccelerator.SetAccelerator(Me.selectToolStripDropDwnBtn, "SL")
            Me.selectToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.selectAllToolStripMenuItem, Me.selectObjectsToolStripMenuItem, Me.selectTextWithSimilarFormattingToolStripMenuItem})
            Me.selectToolStripDropDwnBtn.Image = CType(resources.GetObject("selectToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.selectToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.selectToolStripDropDwnBtn.Name = "selectToolStripDropDwnBtn"
            Me.selectToolStripDropDwnBtn.Size = New System.Drawing.Size(65, 20)
            Me.selectToolStripDropDwnBtn.Text = "Select"
            ToolTipInfo75.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo75.Body.Text = "Select text or objects in the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "document."
            ToolTipInfo75.Body.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ToolTipInfo75.Footer.Hidden = True
            ToolTipInfo75.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo75.Header.Text = "Select"
            ToolTipInfo75.Separator = False
            Me.superToolTip1.SetToolTip(Me.selectToolStripDropDwnBtn, ToolTipInfo75)
            '
            'selectAllToolStripMenuItem
            '
            Me.selectAllToolStripMenuItem.Image = CType(resources.GetObject("selectAllToolStripMenuItem.Image"), System.Drawing.Image)
            Me.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem"
            Me.SetShortcut(Me.selectAllToolStripMenuItem, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys))
            Me.selectAllToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
            Me.selectAllToolStripMenuItem.Text = "Select &All"
            '
            'selectObjectsToolStripMenuItem
            '
            Me.selectObjectsToolStripMenuItem.Image = CType(resources.GetObject("selectObjectsToolStripMenuItem.Image"), System.Drawing.Image)
            Me.selectObjectsToolStripMenuItem.Name = "selectObjectsToolStripMenuItem"
            Me.selectObjectsToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
            Me.selectObjectsToolStripMenuItem.Text = "Select &Objects"
            '
            'selectTextWithSimilarFormattingToolStripMenuItem
            '
            Me.selectTextWithSimilarFormattingToolStripMenuItem.Name = "selectTextWithSimilarFormattingToolStripMenuItem"
            Me.selectTextWithSimilarFormattingToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
            Me.selectTextWithSimilarFormattingToolStripMenuItem.Text = "&Select Text with Similar Formatting"
            '
            'insertTabItem
            '
            Me.superAccelerator.SetAccelerator(Me.insertTabItem, "N")
            Me.insertTabItem.ForeColor = System.Drawing.Color.MidnightBlue
            Me.insertTabItem.Name = "insertTabItem"
            Me.insertTabItem.Padding = New System.Windows.Forms.Padding(15, 2, 3, 5)
            '
            'ribbonControlAdv1.RibbonPanel2
            '
            Me.insertTabItem.Panel.Controls.Add(Me.pagesToolStripExt)
            Me.insertTabItem.Panel.Controls.Add(Me.tablesToolStripExt)
            Me.insertTabItem.Panel.Controls.Add(Me.linksToolStripExt)
            Me.insertTabItem.Panel.Controls.Add(Me.headerToolStripExt)
            Me.insertTabItem.Panel.Controls.Add(Me.textToolStripExt)
            Me.insertTabItem.Panel.Controls.Add(Me.symbolsToolStripExt)
            Me.insertTabItem.Panel.Name = "RibbonPanel2"
            Me.insertTabItem.Panel.ScrollPosition = 0
            Me.insertTabItem.Panel.TabIndex = 2
            Me.insertTabItem.Panel.Text = "Insert"
            Me.insertTabItem.Size = New System.Drawing.Size(58, 24)
            Me.insertTabItem.Text = "Insert"
            '
            'pagesToolStripExt
            '
            Me.pagesToolStripExt.CollapsedDropDownButtonText = "Pages"
            Me.pagesToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.Right
            Me.pagesToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.pagesToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.pagesToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.pagesToolStripExt.Image = CType(resources.GetObject("pagesToolStripExt.Image"), System.Drawing.Image)
            Me.pagesToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.coverPageToolStripDropDwnBtn, Me.blankPageToolStripBtn, Me.pageBreakToolStripBtn})
            Me.pagesToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.pagesToolStripExt.Location = New System.Drawing.Point(0, 1)
            Me.pagesToolStripExt.Name = "pagesToolStripExt"
            Me.pagesToolStripExt.ShowLauncher = False
            Me.pagesToolStripExt.Size = New System.Drawing.Size(97, 0)
            Me.pagesToolStripExt.TabIndex = 1
            Me.pagesToolStripExt.Text = "Pages"
            '
            'coverPageToolStripDropDwnBtn
            '
            Me.coverPageToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.formatPageNumbersToolStripMenuItem, Me.removeCurrentCoverPageToolStripMenuItem, Me.saveSelectionToCoverPageGalleryToolStripMenuItem})
            Me.coverPageToolStripDropDwnBtn.Image = CType(resources.GetObject("coverPageToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.coverPageToolStripDropDwnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.coverPageToolStripDropDwnBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.coverPageToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.coverPageToolStripDropDwnBtn.Name = "coverPageToolStripDropDwnBtn"
            Me.coverPageToolStripDropDwnBtn.Size = New System.Drawing.Size(95, 23)
            Me.coverPageToolStripDropDwnBtn.Text = "Cover Page"
            ToolTipInfo76.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo76.Body.Hidden = True
            ToolTipInfo76.Footer.Hidden = True
            ToolTipInfo76.Header.Text = "Cover Page"
            ToolTipInfo76.Separator = False
            Me.superToolTip1.SetToolTip(Me.coverPageToolStripDropDwnBtn, ToolTipInfo76)
            '
            'formatPageNumbersToolStripMenuItem
            '
            Me.formatPageNumbersToolStripMenuItem.Name = "formatPageNumbersToolStripMenuItem"
            Me.formatPageNumbersToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
            Me.formatPageNumbersToolStripMenuItem.Text = "&Format Page Numbers..."
            '
            'removeCurrentCoverPageToolStripMenuItem
            '
            Me.removeCurrentCoverPageToolStripMenuItem.Name = "removeCurrentCoverPageToolStripMenuItem"
            Me.removeCurrentCoverPageToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
            Me.removeCurrentCoverPageToolStripMenuItem.Text = "&Remove Current Cover Page"
            '
            'saveSelectionToCoverPageGalleryToolStripMenuItem
            '
            Me.saveSelectionToCoverPageGalleryToolStripMenuItem.Enabled = False
            Me.saveSelectionToCoverPageGalleryToolStripMenuItem.Name = "saveSelectionToCoverPageGalleryToolStripMenuItem"
            Me.saveSelectionToCoverPageGalleryToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
            Me.saveSelectionToCoverPageGalleryToolStripMenuItem.Text = "&Save Selection to Cover Page Gallery..."
            '
            'blankPageToolStripBtn
            '
            Me.blankPageToolStripBtn.Image = CType(resources.GetObject("blankPageToolStripBtn.Image"), System.Drawing.Image)
            Me.blankPageToolStripBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.blankPageToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.blankPageToolStripBtn.Name = "blankPageToolStripBtn"
            Me.blankPageToolStripBtn.Size = New System.Drawing.Size(79, 20)
            Me.blankPageToolStripBtn.Text = "Blank Page"
            ToolTipInfo77.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo77.Body.Hidden = True
            ToolTipInfo77.Footer.Hidden = True
            ToolTipInfo77.Header.Text = "Blank Page"
            ToolTipInfo77.Separator = False
            Me.superToolTip1.SetToolTip(Me.blankPageToolStripBtn, ToolTipInfo77)
            '
            'pageBreakToolStripBtn
            '
            Me.pageBreakToolStripBtn.Image = CType(resources.GetObject("pageBreakToolStripBtn.Image"), System.Drawing.Image)
            Me.pageBreakToolStripBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.pageBreakToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.pageBreakToolStripBtn.Name = "pageBreakToolStripBtn"
            Me.pageBreakToolStripBtn.Size = New System.Drawing.Size(81, 20)
            Me.pageBreakToolStripBtn.Text = "Page Break"
            ToolTipInfo78.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo78.Body.Hidden = True
            ToolTipInfo78.Footer.Hidden = True
            ToolTipInfo78.Header.Text = "Page Break"
            ToolTipInfo78.Separator = False
            Me.superToolTip1.SetToolTip(Me.pageBreakToolStripBtn, ToolTipInfo78)
            '
            'tablesToolStripExt
            '
            Me.tablesToolStripExt.CollapsedDropDownButtonText = "Table"
            Me.tablesToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.tablesToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.tablesToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.tablesToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.tablesToolStripExt.Image = CType(resources.GetObject("tablesToolStripExt.Image"), System.Drawing.Image)
            Me.tablesToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tableToolStripDropDwnBtn})
            Me.tablesToolStripExt.Location = New System.Drawing.Point(97, 1)
            Me.tablesToolStripExt.Name = "tablesToolStripExt"
            Me.tablesToolStripExt.ShowLauncher = False
            Me.tablesToolStripExt.Size = New System.Drawing.Size(60, 0)
            Me.tablesToolStripExt.TabIndex = 2
            Me.tablesToolStripExt.Text = "Tables"
            '
            'tableToolStripDropDwnBtn
            '
            Me.tableToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.insertTableToolStripMenuItem, Me.drawTableToolStripMenuItem, Me.convertTextToTableToolStripMenuItem, Me.excelSpreadsheetToolStripMenuItem, Me.quickTablesToolStripMenuItem})
            Me.tableToolStripDropDwnBtn.Image = CType(resources.GetObject("tableToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.tableToolStripDropDwnBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tableToolStripDropDwnBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tableToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tableToolStripDropDwnBtn.Name = "tableToolStripDropDwnBtn"
            Me.tableToolStripDropDwnBtn.Size = New System.Drawing.Size(46, 0)
            Me.tableToolStripDropDwnBtn.Text = "Table"
            Me.tableToolStripDropDwnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo79.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo79.Body.Hidden = True
            ToolTipInfo79.Footer.Hidden = True
            ToolTipInfo79.Header.Text = "Table"
            ToolTipInfo79.Separator = False
            Me.superToolTip1.SetToolTip(Me.tableToolStripDropDwnBtn, ToolTipInfo79)
            '
            'insertTableToolStripMenuItem
            '
            Me.insertTableToolStripMenuItem.Name = "insertTableToolStripMenuItem"
            Me.insertTableToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
            Me.insertTableToolStripMenuItem.Text = "&Insert Table..."
            '
            'drawTableToolStripMenuItem
            '
            Me.drawTableToolStripMenuItem.Name = "drawTableToolStripMenuItem"
            Me.drawTableToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
            Me.drawTableToolStripMenuItem.Text = "&Draw Table"
            '
            'convertTextToTableToolStripMenuItem
            '
            Me.convertTextToTableToolStripMenuItem.Name = "convertTextToTableToolStripMenuItem"
            Me.convertTextToTableToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
            Me.convertTextToTableToolStripMenuItem.Text = "Conv&ert Text to Table..."
            '
            'excelSpreadsheetToolStripMenuItem
            '
            Me.excelSpreadsheetToolStripMenuItem.Name = "excelSpreadsheetToolStripMenuItem"
            Me.excelSpreadsheetToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
            Me.excelSpreadsheetToolStripMenuItem.Text = "E&xcel Spreadsheet"
            '
            'quickTablesToolStripMenuItem
            '
            Me.quickTablesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.saveSelectionToQuickTablToolStripMenuItem})
            Me.quickTablesToolStripMenuItem.Name = "quickTablesToolStripMenuItem"
            Me.quickTablesToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
            Me.quickTablesToolStripMenuItem.Text = "Quick &Tables"
            '
            'saveSelectionToQuickTablToolStripMenuItem
            '
            Me.saveSelectionToQuickTablToolStripMenuItem.Enabled = False
            Me.saveSelectionToQuickTablToolStripMenuItem.Name = "saveSelectionToQuickTablToolStripMenuItem"
            Me.saveSelectionToQuickTablToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
            Me.saveSelectionToQuickTablToolStripMenuItem.Text = "&Save Selection to Quick Tables Gallery..."
            '
            'linksToolStripExt
            '
            Me.linksToolStripExt.CollapsedDropDownButtonText = "Links"
            Me.linksToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.Right
            Me.linksToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.linksToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.linksToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.linksToolStripExt.Image = CType(resources.GetObject("linksToolStripExt.Image"), System.Drawing.Image)
            Me.linksToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.hyperlinkToolStripBtn, Me.bookmarkToolStripBtn, Me.crossrefToolStripBtn})
            Me.linksToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.linksToolStripExt.Location = New System.Drawing.Point(157, 1)
            Me.linksToolStripExt.Name = "linksToolStripExt"
            Me.linksToolStripExt.ShowLauncher = False
            Me.linksToolStripExt.Size = New System.Drawing.Size(110, 0)
            Me.linksToolStripExt.TabIndex = 4
            Me.linksToolStripExt.Text = "Links"
            '
            'hyperlinkToolStripBtn
            '
            Me.hyperlinkToolStripBtn.Image = CType(resources.GetObject("hyperlinkToolStripBtn.Image"), System.Drawing.Image)
            Me.hyperlinkToolStripBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.hyperlinkToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.hyperlinkToolStripBtn.Name = "hyperlinkToolStripBtn"
            Me.hyperlinkToolStripBtn.Size = New System.Drawing.Size(71, 20)
            Me.hyperlinkToolStripBtn.Text = "Hyperlink"
            ToolTipInfo80.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo80.Body.Hidden = True
            ToolTipInfo80.Footer.Hidden = True
            ToolTipInfo80.Header.Text = "Hyperlink"
            ToolTipInfo80.Separator = False
            Me.superToolTip1.SetToolTip(Me.hyperlinkToolStripBtn, ToolTipInfo80)
            '
            'bookmarkToolStripBtn
            '
            Me.bookmarkToolStripBtn.Image = CType(resources.GetObject("bookmarkToolStripBtn.Image"), System.Drawing.Image)
            Me.bookmarkToolStripBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.bookmarkToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bookmarkToolStripBtn.Name = "bookmarkToolStripBtn"
            Me.bookmarkToolStripBtn.Size = New System.Drawing.Size(73, 20)
            Me.bookmarkToolStripBtn.Text = "Bookmark"
            ToolTipInfo81.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo81.Body.Hidden = True
            ToolTipInfo81.Footer.Hidden = True
            ToolTipInfo81.Header.Text = "Bookmark"
            ToolTipInfo81.Separator = False
            Me.superToolTip1.SetToolTip(Me.bookmarkToolStripBtn, ToolTipInfo81)
            '
            'crossrefToolStripBtn
            '
            Me.crossrefToolStripBtn.Image = CType(resources.GetObject("crossrefToolStripBtn.Image"), System.Drawing.Image)
            Me.crossrefToolStripBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.crossrefToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.crossrefToolStripBtn.Name = "crossrefToolStripBtn"
            Me.crossrefToolStripBtn.Size = New System.Drawing.Size(105, 20)
            Me.crossrefToolStripBtn.Text = "Cross-reference"
            ToolTipInfo82.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo82.Body.Hidden = True
            ToolTipInfo82.Footer.Hidden = True
            ToolTipInfo82.Header.Text = "Cross-reference"
            ToolTipInfo82.Separator = False
            Me.superToolTip1.SetToolTip(Me.crossrefToolStripBtn, ToolTipInfo82)
            '
            'headerToolStripExt
            '
            Me.headerToolStripExt.CollapsedDropDownButtonText = "Header & Footer"
            Me.headerToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.Right
            Me.headerToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.headerToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.headerToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.headerToolStripExt.Image = CType(resources.GetObject("headerToolStripExt.Image"), System.Drawing.Image)
            Me.headerToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.headerToolStripSplitBtn, Me.footerToolStripSplitBtn, Me.pagenoToolStripSplitBtn})
            Me.headerToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.headerToolStripExt.Location = New System.Drawing.Point(267, 1)
            Me.headerToolStripExt.Name = "headerToolStripExt"
            Me.headerToolStripExt.ShowLauncher = False
            Me.headerToolStripExt.Size = New System.Drawing.Size(110, 0)
            Me.headerToolStripExt.TabIndex = 5
            Me.headerToolStripExt.Text = "Header && Footer"
            '
            'headerToolStripSplitBtn
            '
            Me.headerToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.editHeaderToolStripMenuItem, Me.removeHeaderToolStripMenuItem, Me.saveSelectionToHeaderGalleryToolStripMenuItem})
            Me.headerToolStripSplitBtn.Image = CType(resources.GetObject("headerToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.headerToolStripSplitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.headerToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.headerToolStripSplitBtn.Name = "headerToolStripSplitBtn"
            Me.headerToolStripSplitBtn.Size = New System.Drawing.Size(74, 20)
            Me.headerToolStripSplitBtn.Text = "Header"
            ToolTipInfo83.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo83.Body.Hidden = True
            ToolTipInfo83.Footer.Hidden = True
            ToolTipInfo83.Header.Text = "Header"
            ToolTipInfo83.Separator = False
            Me.superToolTip1.SetToolTip(Me.headerToolStripSplitBtn, ToolTipInfo83)
            '
            'editHeaderToolStripMenuItem
            '
            Me.editHeaderToolStripMenuItem.Name = "editHeaderToolStripMenuItem"
            Me.editHeaderToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
            Me.editHeaderToolStripMenuItem.Text = "&Edit Header"
            '
            'removeHeaderToolStripMenuItem
            '
            Me.removeHeaderToolStripMenuItem.Name = "removeHeaderToolStripMenuItem"
            Me.removeHeaderToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
            Me.removeHeaderToolStripMenuItem.Text = "&Remove Header"
            '
            'saveSelectionToHeaderGalleryToolStripMenuItem
            '
            Me.saveSelectionToHeaderGalleryToolStripMenuItem.Enabled = False
            Me.saveSelectionToHeaderGalleryToolStripMenuItem.Name = "saveSelectionToHeaderGalleryToolStripMenuItem"
            Me.saveSelectionToHeaderGalleryToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
            Me.saveSelectionToHeaderGalleryToolStripMenuItem.Text = "&Save Selection to Header Gallery..."
            '
            'footerToolStripSplitBtn
            '
            Me.footerToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.editFooterToolStripMenuItem, Me.removeFooterToolStripMenuItem, Me.saveSelectionToFooterGalleryToolStripMenuItem})
            Me.footerToolStripSplitBtn.Image = CType(resources.GetObject("footerToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.footerToolStripSplitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.footerToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.footerToolStripSplitBtn.Name = "footerToolStripSplitBtn"
            Me.footerToolStripSplitBtn.Size = New System.Drawing.Size(71, 20)
            Me.footerToolStripSplitBtn.Text = "Footer"
            ToolTipInfo84.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo84.Body.Hidden = True
            ToolTipInfo84.Footer.Hidden = True
            ToolTipInfo84.Header.Text = "Footer"
            ToolTipInfo84.Separator = False
            Me.superToolTip1.SetToolTip(Me.footerToolStripSplitBtn, ToolTipInfo84)
            '
            'editFooterToolStripMenuItem
            '
            Me.editFooterToolStripMenuItem.Name = "editFooterToolStripMenuItem"
            Me.editFooterToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
            Me.editFooterToolStripMenuItem.Text = "&Edit Footer"
            '
            'removeFooterToolStripMenuItem
            '
            Me.removeFooterToolStripMenuItem.Name = "removeFooterToolStripMenuItem"
            Me.removeFooterToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
            Me.removeFooterToolStripMenuItem.Text = "&Remove Footer"
            '
            'saveSelectionToFooterGalleryToolStripMenuItem
            '
            Me.saveSelectionToFooterGalleryToolStripMenuItem.Name = "saveSelectionToFooterGalleryToolStripMenuItem"
            Me.saveSelectionToFooterGalleryToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
            Me.saveSelectionToFooterGalleryToolStripMenuItem.Text = "&Save Selection to Footer Gallery..."
            '
            'pagenoToolStripSplitBtn
            '
            Me.pagenoToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.topOfPageToolStripMenuItem, Me.bottomOfPageToolStripMenuItem, Me.pageMarginsToolStripMenuItem, Me.formatPageNumbersToolStripMenuItem1, Me.removePageNumbersToolStripMenuItem})
            Me.pagenoToolStripSplitBtn.Image = CType(resources.GetObject("pagenoToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.pagenoToolStripSplitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.pagenoToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.pagenoToolStripSplitBtn.Name = "pagenoToolStripSplitBtn"
            Me.pagenoToolStripSplitBtn.Size = New System.Drawing.Size(103, 20)
            Me.pagenoToolStripSplitBtn.Text = "Page Number"
            ToolTipInfo85.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo85.Body.Hidden = True
            ToolTipInfo85.Footer.Hidden = True
            ToolTipInfo85.Header.Text = "Page Number"
            ToolTipInfo85.Separator = False
            Me.superToolTip1.SetToolTip(Me.pagenoToolStripSplitBtn, ToolTipInfo85)
            '
            'topOfPageToolStripMenuItem
            '
            Me.topOfPageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.headerFooterToolStripMenuItem, Me.saveSelectionAsPageNumberTopToolStripMenuItem})
            Me.topOfPageToolStripMenuItem.Name = "topOfPageToolStripMenuItem"
            Me.topOfPageToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
            Me.topOfPageToolStripMenuItem.Text = "&Top of Page"
            '
            'headerFooterToolStripMenuItem
            '
            Me.headerFooterToolStripMenuItem.Name = "headerFooterToolStripMenuItem"
            Me.headerFooterToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
            Me.headerFooterToolStripMenuItem.Text = "&Header && Footer..."
            '
            'saveSelectionAsPageNumberTopToolStripMenuItem
            '
            Me.saveSelectionAsPageNumberTopToolStripMenuItem.Enabled = False
            Me.saveSelectionAsPageNumberTopToolStripMenuItem.Name = "saveSelectionAsPageNumberTopToolStripMenuItem"
            Me.saveSelectionAsPageNumberTopToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
            Me.saveSelectionAsPageNumberTopToolStripMenuItem.Text = "&Save Selection as Page Number (Top)"
            '
            'bottomOfPageToolStripMenuItem
            '
            Me.bottomOfPageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.headerFooterToolStripMenuItem1, Me.saveSelectionAsPageNumberBottomToolStripMenuItem})
            Me.bottomOfPageToolStripMenuItem.Name = "bottomOfPageToolStripMenuItem"
            Me.bottomOfPageToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
            Me.bottomOfPageToolStripMenuItem.Text = "&Bottom of Page"
            '
            'headerFooterToolStripMenuItem1
            '
            Me.headerFooterToolStripMenuItem1.Name = "headerFooterToolStripMenuItem1"
            Me.headerFooterToolStripMenuItem1.Size = New System.Drawing.Size(281, 22)
            Me.headerFooterToolStripMenuItem1.Text = "&Header && Footer..."
            '
            'saveSelectionAsPageNumberBottomToolStripMenuItem
            '
            Me.saveSelectionAsPageNumberBottomToolStripMenuItem.Enabled = False
            Me.saveSelectionAsPageNumberBottomToolStripMenuItem.Name = "saveSelectionAsPageNumberBottomToolStripMenuItem"
            Me.saveSelectionAsPageNumberBottomToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
            Me.saveSelectionAsPageNumberBottomToolStripMenuItem.Text = "&Save Selection as Page Number (Bottom)"
            '
            'pageMarginsToolStripMenuItem
            '
            Me.pageMarginsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sAveSelectionAsPageMarginToolStripMenuItem})
            Me.pageMarginsToolStripMenuItem.Name = "pageMarginsToolStripMenuItem"
            Me.pageMarginsToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
            Me.pageMarginsToolStripMenuItem.Text = "&Page Margins"
            '
            'sAveSelectionAsPageMarginToolStripMenuItem
            '
            Me.sAveSelectionAsPageMarginToolStripMenuItem.Name = "sAveSelectionAsPageMarginToolStripMenuItem"
            Me.sAveSelectionAsPageMarginToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
            Me.sAveSelectionAsPageMarginToolStripMenuItem.Text = "&Save Selection as Page Number (Margin)"
            '
            'formatPageNumbersToolStripMenuItem1
            '
            Me.formatPageNumbersToolStripMenuItem1.Name = "formatPageNumbersToolStripMenuItem1"
            Me.formatPageNumbersToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
            Me.formatPageNumbersToolStripMenuItem1.Text = "&Format Page Numbers..."
            '
            'removePageNumbersToolStripMenuItem
            '
            Me.removePageNumbersToolStripMenuItem.Name = "removePageNumbersToolStripMenuItem"
            Me.removePageNumbersToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
            Me.removePageNumbersToolStripMenuItem.Text = "&Remove Page Numbers"
            '
            'textToolStripExt
            '
            Me.textToolStripExt.CollapsedDropDownButtonText = "Text"
            Me.textToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.textToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.textToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.textToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.textToolStripExt.Image = CType(resources.GetObject("textToolStripExt.Image"), System.Drawing.Image)
            Me.textToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtboxToolStripSplitBtn, Me.toolStripPanelItem11, Me.toolStripPanelItem12})
            Me.textToolStripExt.Location = New System.Drawing.Point(377, 1)
            Me.textToolStripExt.Name = "textToolStripExt"
            Me.textToolStripExt.ShowLauncher = False
            Me.textToolStripExt.Size = New System.Drawing.Size(280, 0)
            Me.textToolStripExt.TabIndex = 6
            Me.textToolStripExt.Text = "Text"
            '
            'txtboxToolStripSplitBtn
            '
            Me.txtboxToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.drawTextBoxToolStripMenuItem, Me.saveSelectionToTextBoxGalleryToolStripMenuItem})
            Me.txtboxToolStripSplitBtn.Image = CType(resources.GetObject("txtboxToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.txtboxToolStripSplitBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.txtboxToolStripSplitBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.txtboxToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.txtboxToolStripSplitBtn.Name = "txtboxToolStripSplitBtn"
            Me.txtboxToolStripSplitBtn.Size = New System.Drawing.Size(63, 0)
            Me.txtboxToolStripSplitBtn.Text = "Text Box"
            Me.txtboxToolStripSplitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo86.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo86.Body.Hidden = True
            ToolTipInfo86.Footer.Hidden = True
            ToolTipInfo86.Header.Text = "Text Box"
            ToolTipInfo86.Separator = False
            Me.superToolTip1.SetToolTip(Me.txtboxToolStripSplitBtn, ToolTipInfo86)
            '
            'drawTextBoxToolStripMenuItem
            '
            Me.drawTextBoxToolStripMenuItem.Name = "drawTextBoxToolStripMenuItem"
            Me.drawTextBoxToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
            Me.drawTextBoxToolStripMenuItem.Text = "&Draw Text Box"
            '
            'saveSelectionToTextBoxGalleryToolStripMenuItem
            '
            Me.saveSelectionToTextBoxGalleryToolStripMenuItem.Enabled = False
            Me.saveSelectionToTextBoxGalleryToolStripMenuItem.Name = "saveSelectionToTextBoxGalleryToolStripMenuItem"
            Me.saveSelectionToTextBoxGalleryToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
            Me.saveSelectionToTextBoxGalleryToolStripMenuItem.Text = "&Save Selection to Text Box Gallery"
            '
            'toolStripPanelItem11
            '
            Me.toolStripPanelItem11.CausesValidation = False
            Me.toolStripPanelItem11.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem11.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.qckPartsToolStripSplitBtn, Me.wordArtToolStripSplitBtn, Me.dropCapToolStripSplitBtn})
            Me.toolStripPanelItem11.Name = "toolStripPanelItem11"
            Me.toolStripPanelItem11.Size = New System.Drawing.Size(97, 0)
            Me.toolStripPanelItem11.Text = "toolStripPanelItem11"
            Me.toolStripPanelItem11.Transparent = True
            '
            'qckPartsToolStripSplitBtn
            '
            Me.qckPartsToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.propertyToolStripMenuItem, Me.fieldToolStripMenuItem, Me.pageNumbersToolStripMenuItem, Me.toolStripSeparator18, Me.buildingBlocksOrganizerToolStripMenuItem, Me.getMoreOnOfficeOnlineToolStripMenuItem, Me.saveSelectionToQuickPartGalleryToolStripMenuItem})
            Me.qckPartsToolStripSplitBtn.Image = CType(resources.GetObject("qckPartsToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.qckPartsToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.qckPartsToolStripSplitBtn.Name = "qckPartsToolStripSplitBtn"
            Me.qckPartsToolStripSplitBtn.Size = New System.Drawing.Size(93, 20)
            Me.qckPartsToolStripSplitBtn.Text = "Quick Parts"
            ToolTipInfo87.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo87.Body.Hidden = True
            ToolTipInfo87.Footer.Hidden = True
            ToolTipInfo87.Header.Text = "Quick Parts"
            ToolTipInfo87.Separator = False
            Me.superToolTip1.SetToolTip(Me.qckPartsToolStripSplitBtn, ToolTipInfo87)
            '
            'propertyToolStripMenuItem
            '
            Me.propertyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.abstractToolStripMenuItem, Me.authorToolStripMenuItem, Me.categoryToolStripMenuItem, Me.commentsToolStripMenuItem, Me.companyToolStripMenuItem, Me.companyAddressToolStripMenuItem, Me.companyEmailToolStripMenuItem, Me.companyFaxToolStripMenuItem, Me.companyPhoneToolStripMenuItem, Me.keywordsToolStripMenuItem, Me.managerToolStripMenuItem, Me.publishDateToolStripMenuItem, Me.statusToolStripMenuItem, Me.subjectToolStripMenuItem, Me.titleToolStripMenuItem})
            Me.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem"
            Me.propertyToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
            Me.propertyToolStripMenuItem.Text = "&Property"
            '
            'abstractToolStripMenuItem
            '
            Me.abstractToolStripMenuItem.Name = "abstractToolStripMenuItem"
            Me.abstractToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.abstractToolStripMenuItem.Text = "Abstract"
            '
            'authorToolStripMenuItem
            '
            Me.authorToolStripMenuItem.Name = "authorToolStripMenuItem"
            Me.authorToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.authorToolStripMenuItem.Text = "Author"
            '
            'categoryToolStripMenuItem
            '
            Me.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem"
            Me.categoryToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.categoryToolStripMenuItem.Text = "Category"
            '
            'commentsToolStripMenuItem
            '
            Me.commentsToolStripMenuItem.Name = "commentsToolStripMenuItem"
            Me.commentsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.commentsToolStripMenuItem.Text = "Comments"
            '
            'companyToolStripMenuItem
            '
            Me.companyToolStripMenuItem.Name = "companyToolStripMenuItem"
            Me.companyToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.companyToolStripMenuItem.Text = "Company"
            '
            'companyAddressToolStripMenuItem
            '
            Me.companyAddressToolStripMenuItem.Name = "companyAddressToolStripMenuItem"
            Me.companyAddressToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.companyAddressToolStripMenuItem.Text = "Company Address"
            '
            'companyEmailToolStripMenuItem
            '
            Me.companyEmailToolStripMenuItem.Name = "companyEmailToolStripMenuItem"
            Me.companyEmailToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.companyEmailToolStripMenuItem.Text = "Company E-mail"
            '
            'companyFaxToolStripMenuItem
            '
            Me.companyFaxToolStripMenuItem.Name = "companyFaxToolStripMenuItem"
            Me.companyFaxToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.companyFaxToolStripMenuItem.Text = "Company Fax"
            '
            'companyPhoneToolStripMenuItem
            '
            Me.companyPhoneToolStripMenuItem.Name = "companyPhoneToolStripMenuItem"
            Me.companyPhoneToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.companyPhoneToolStripMenuItem.Text = "Company Phone"
            '
            'keywordsToolStripMenuItem
            '
            Me.keywordsToolStripMenuItem.Name = "keywordsToolStripMenuItem"
            Me.keywordsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.keywordsToolStripMenuItem.Text = "Keywords"
            '
            'managerToolStripMenuItem
            '
            Me.managerToolStripMenuItem.Name = "managerToolStripMenuItem"
            Me.managerToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.managerToolStripMenuItem.Text = "Manager"
            '
            'publishDateToolStripMenuItem
            '
            Me.publishDateToolStripMenuItem.Name = "publishDateToolStripMenuItem"
            Me.publishDateToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.publishDateToolStripMenuItem.Text = "Publish Date"
            '
            'statusToolStripMenuItem
            '
            Me.statusToolStripMenuItem.Name = "statusToolStripMenuItem"
            Me.statusToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.statusToolStripMenuItem.Text = "Status"
            '
            'subjectToolStripMenuItem
            '
            Me.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem"
            Me.subjectToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.subjectToolStripMenuItem.Text = "Subject"
            '
            'titleToolStripMenuItem
            '
            Me.titleToolStripMenuItem.Name = "titleToolStripMenuItem"
            Me.titleToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.titleToolStripMenuItem.Text = "Title"
            '
            'fieldToolStripMenuItem
            '
            Me.fieldToolStripMenuItem.Name = "fieldToolStripMenuItem"
            Me.fieldToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
            Me.fieldToolStripMenuItem.Text = "&Field..."
            '
            'pageNumbersToolStripMenuItem
            '
            Me.pageNumbersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.saveSelectionToPageNumberGalleryToolStripMenuItem})
            Me.pageNumbersToolStripMenuItem.Name = "pageNumbersToolStripMenuItem"
            Me.pageNumbersToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
            Me.pageNumbersToolStripMenuItem.Text = "Page &Numbers"
            '
            'saveSelectionToPageNumberGalleryToolStripMenuItem
            '
            Me.saveSelectionToPageNumberGalleryToolStripMenuItem.Enabled = False
            Me.saveSelectionToPageNumberGalleryToolStripMenuItem.Name = "saveSelectionToPageNumberGalleryToolStripMenuItem"
            Me.saveSelectionToPageNumberGalleryToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
            Me.saveSelectionToPageNumberGalleryToolStripMenuItem.Text = "&Save Selection to Page Number Gallery..."
            '
            'toolStripSeparator18
            '
            Me.toolStripSeparator18.Name = "toolStripSeparator18"
            Me.toolStripSeparator18.Size = New System.Drawing.Size(265, 6)
            '
            'buildingBlocksOrganizerToolStripMenuItem
            '
            Me.buildingBlocksOrganizerToolStripMenuItem.Name = "buildingBlocksOrganizerToolStripMenuItem"
            Me.buildingBlocksOrganizerToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
            Me.buildingBlocksOrganizerToolStripMenuItem.Text = "&Building Blocks Organizer..."
            '
            'getMoreOnOfficeOnlineToolStripMenuItem
            '
            Me.getMoreOnOfficeOnlineToolStripMenuItem.Name = "getMoreOnOfficeOnlineToolStripMenuItem"
            Me.getMoreOnOfficeOnlineToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
            Me.getMoreOnOfficeOnlineToolStripMenuItem.Text = "&Get More on Office Online..."
            '
            'saveSelectionToQuickPartGalleryToolStripMenuItem
            '
            Me.saveSelectionToQuickPartGalleryToolStripMenuItem.Enabled = False
            Me.saveSelectionToQuickPartGalleryToolStripMenuItem.Name = "saveSelectionToQuickPartGalleryToolStripMenuItem"
            Me.saveSelectionToQuickPartGalleryToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
            Me.saveSelectionToQuickPartGalleryToolStripMenuItem.Text = "&Save Selection to Quick Part Gallery..."
            '
            'wordArtToolStripSplitBtn
            '
            Me.wordArtToolStripSplitBtn.Image = CType(resources.GetObject("wordArtToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.wordArtToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.wordArtToolStripSplitBtn.Name = "wordArtToolStripSplitBtn"
            Me.wordArtToolStripSplitBtn.Size = New System.Drawing.Size(77, 20)
            Me.wordArtToolStripSplitBtn.Text = "WordArt"
            ToolTipInfo88.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo88.Body.Hidden = True
            ToolTipInfo88.Footer.Hidden = True
            ToolTipInfo88.Header.Text = "Word Art"
            ToolTipInfo88.Separator = False
            Me.superToolTip1.SetToolTip(Me.wordArtToolStripSplitBtn, ToolTipInfo88)
            '
            'dropCapToolStripSplitBtn
            '
            Me.dropCapToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.advancedToolStripMenuItem})
            Me.dropCapToolStripSplitBtn.Image = CType(resources.GetObject("dropCapToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.dropCapToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.dropCapToolStripSplitBtn.Name = "dropCapToolStripSplitBtn"
            Me.dropCapToolStripSplitBtn.Size = New System.Drawing.Size(81, 20)
            Me.dropCapToolStripSplitBtn.Text = "Drop Cap"
            ToolTipInfo89.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo89.Body.Hidden = True
            ToolTipInfo89.Footer.Hidden = True
            ToolTipInfo89.Header.Text = "Drop Cap"
            ToolTipInfo89.Separator = False
            Me.superToolTip1.SetToolTip(Me.dropCapToolStripSplitBtn, ToolTipInfo89)
            '
            'advancedToolStripMenuItem
            '
            Me.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem"
            Me.advancedToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
            Me.advancedToolStripMenuItem.Text = "&Advanced..."
            '
            'toolStripPanelItem12
            '
            Me.toolStripPanelItem12.CausesValidation = False
            Me.toolStripPanelItem12.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem12.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.signLineToolStripSplitBtn, Me.dateTimeToolStripBtn, Me.objectToolStripSplitBtn})
            Me.toolStripPanelItem12.Name = "toolStripPanelItem12"
            Me.toolStripPanelItem12.Size = New System.Drawing.Size(111, 0)
            Me.toolStripPanelItem12.Text = "toolStripPanelItem12"
            Me.toolStripPanelItem12.Transparent = True
            '
            'signLineToolStripSplitBtn
            '
            Me.signLineToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.microsoftOfficeSignatureLineToolStripMenuItem, Me.toolStripSeparator19, Me.addSignatureServicesToolStripMenuItem})
            Me.signLineToolStripSplitBtn.Image = CType(resources.GetObject("signLineToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.signLineToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.signLineToolStripSplitBtn.Name = "signLineToolStripSplitBtn"
            Me.signLineToolStripSplitBtn.Size = New System.Drawing.Size(107, 20)
            Me.signLineToolStripSplitBtn.Text = "Signature Line"
            ToolTipInfo90.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo90.Body.Hidden = True
            ToolTipInfo90.Footer.Hidden = True
            ToolTipInfo90.Header.Text = "Signature Line"
            ToolTipInfo90.Separator = False
            Me.superToolTip1.SetToolTip(Me.signLineToolStripSplitBtn, ToolTipInfo90)
            '
            'microsoftOfficeSignatureLineToolStripMenuItem
            '
            Me.microsoftOfficeSignatureLineToolStripMenuItem.Name = "microsoftOfficeSignatureLineToolStripMenuItem"
            Me.microsoftOfficeSignatureLineToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
            Me.microsoftOfficeSignatureLineToolStripMenuItem.Text = "Microsoft Office Signature Line"
            '
            'toolStripSeparator19
            '
            Me.toolStripSeparator19.Name = "toolStripSeparator19"
            Me.toolStripSeparator19.Size = New System.Drawing.Size(229, 6)
            '
            'addSignatureServicesToolStripMenuItem
            '
            Me.addSignatureServicesToolStripMenuItem.Name = "addSignatureServicesToolStripMenuItem"
            Me.addSignatureServicesToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
            Me.addSignatureServicesToolStripMenuItem.Text = "&Add Signature Services"
            '
            'dateTimeToolStripBtn
            '
            Me.dateTimeToolStripBtn.Image = CType(resources.GetObject("dateTimeToolStripBtn.Image"), System.Drawing.Image)
            Me.dateTimeToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.dateTimeToolStripBtn.Name = "dateTimeToolStripBtn"
            Me.dateTimeToolStripBtn.Size = New System.Drawing.Size(85, 20)
            Me.dateTimeToolStripBtn.Text = "Date && Time"
            ToolTipInfo91.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo91.Header.Text = "Date && Time"
            Me.superToolTip1.SetToolTip(Me.dateTimeToolStripBtn, ToolTipInfo91)
            '
            'objectToolStripSplitBtn
            '
            Me.objectToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.textFromFileToolStripMenuItem, Me.objectToolStripMenuItem})
            Me.objectToolStripSplitBtn.Image = CType(resources.GetObject("objectToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.objectToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.objectToolStripSplitBtn.Name = "objectToolStripSplitBtn"
            Me.objectToolStripSplitBtn.Size = New System.Drawing.Size(71, 20)
            Me.objectToolStripSplitBtn.Text = "Object"
            ToolTipInfo92.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo92.Body.Hidden = True
            ToolTipInfo92.Footer.Hidden = True
            ToolTipInfo92.Header.Text = "Object"
            ToolTipInfo92.Separator = False
            Me.superToolTip1.SetToolTip(Me.objectToolStripSplitBtn, ToolTipInfo92)
            '
            'textFromFileToolStripMenuItem
            '
            Me.textFromFileToolStripMenuItem.Name = "textFromFileToolStripMenuItem"
            Me.textFromFileToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
            Me.textFromFileToolStripMenuItem.Text = "Text &From File..."
            '
            'objectToolStripMenuItem
            '
            Me.objectToolStripMenuItem.Name = "objectToolStripMenuItem"
            Me.objectToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
            Me.objectToolStripMenuItem.Text = "Ob&ject..."
            '
            'symbolsToolStripExt
            '
            Me.symbolsToolStripExt.CollapsedDropDownButtonText = "Symbols"
            Me.symbolsToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.Right
            Me.symbolsToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.symbolsToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.symbolsToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.symbolsToolStripExt.Image = CType(resources.GetObject("symbolsToolStripExt.Image"), System.Drawing.Image)
            Me.symbolsToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.equationToolStripDropDwnBtn, Me.symbolToolStripDropDwnBtn})
            Me.symbolsToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.symbolsToolStripExt.Location = New System.Drawing.Point(657, 1)
            Me.symbolsToolStripExt.Name = "symbolsToolStripExt"
            Me.symbolsToolStripExt.ShowLauncher = False
            Me.symbolsToolStripExt.Size = New System.Drawing.Size(78, 0)
            Me.symbolsToolStripExt.TabIndex = 7
            Me.symbolsToolStripExt.Text = "Symbols"
            '
            'equationToolStripDropDwnBtn
            '
            Me.equationToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.insertNewEquationToolStripMenuItem, Me.saveSelectionToEquationGalleryToolStripMenuItem})
            Me.equationToolStripDropDwnBtn.Image = CType(resources.GetObject("equationToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.equationToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.equationToolStripDropDwnBtn.Name = "equationToolStripDropDwnBtn"
            Me.equationToolStripDropDwnBtn.Size = New System.Drawing.Size(81, 20)
            Me.equationToolStripDropDwnBtn.Text = "Equation"
            ToolTipInfo93.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo93.Body.Hidden = True
            ToolTipInfo93.Footer.Hidden = True
            ToolTipInfo93.Header.Text = "Equation"
            ToolTipInfo93.Separator = False
            Me.superToolTip1.SetToolTip(Me.equationToolStripDropDwnBtn, ToolTipInfo93)
            '
            'insertNewEquationToolStripMenuItem
            '
            Me.insertNewEquationToolStripMenuItem.Name = "insertNewEquationToolStripMenuItem"
            Me.insertNewEquationToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
            Me.insertNewEquationToolStripMenuItem.Text = "&Insert New Equation"
            '
            'saveSelectionToEquationGalleryToolStripMenuItem
            '
            Me.saveSelectionToEquationGalleryToolStripMenuItem.Enabled = False
            Me.saveSelectionToEquationGalleryToolStripMenuItem.Name = "saveSelectionToEquationGalleryToolStripMenuItem"
            Me.saveSelectionToEquationGalleryToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
            Me.saveSelectionToEquationGalleryToolStripMenuItem.Text = "&Save Selection to Equation Gallery..."
            '
            'symbolToolStripDropDwnBtn
            '
            Me.symbolToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.moreSymbolsToolStripMenuItem})
            Me.symbolToolStripDropDwnBtn.Image = CType(resources.GetObject("symbolToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.symbolToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.symbolToolStripDropDwnBtn.Name = "symbolToolStripDropDwnBtn"
            Me.symbolToolStripDropDwnBtn.Size = New System.Drawing.Size(70, 20)
            Me.symbolToolStripDropDwnBtn.Text = "Symbol"
            ToolTipInfo94.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo94.Body.Hidden = True
            ToolTipInfo94.Footer.Hidden = True
            ToolTipInfo94.Header.Text = "Symbol"
            ToolTipInfo94.Separator = False
            Me.superToolTip1.SetToolTip(Me.symbolToolStripDropDwnBtn, ToolTipInfo94)
            '
            'moreSymbolsToolStripMenuItem
            '
            Me.moreSymbolsToolStripMenuItem.Name = "moreSymbolsToolStripMenuItem"
            Me.moreSymbolsToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
            Me.moreSymbolsToolStripMenuItem.Text = "&More Symbols..."
            '
            'pageLayoutTabItem
            '
            Me.superAccelerator.SetAccelerator(Me.pageLayoutTabItem, "P")
            Me.pageLayoutTabItem.ForeColor = System.Drawing.Color.MidnightBlue
            Me.pageLayoutTabItem.Name = "pageLayoutTabItem"
            Me.pageLayoutTabItem.Padding = New System.Windows.Forms.Padding(15, 2, 3, 5)
            '
            'ribbonControlAdv1.RibbonPanel3
            '
            Me.pageLayoutTabItem.Panel.Controls.Add(Me.themesToolStripExt)
            Me.pageLayoutTabItem.Panel.Controls.Add(Me.pageSetupToolStripExt)
            Me.pageLayoutTabItem.Panel.Controls.Add(Me.pageBackgroundToolStripExt)
            Me.pageLayoutTabItem.Panel.Controls.Add(Me.paraToolStripExt)
            Me.pageLayoutTabItem.Panel.Controls.Add(Me.arrangeToolStripExt)
            Me.pageLayoutTabItem.Panel.Name = "RibbonPanel3"
            Me.pageLayoutTabItem.Panel.ScrollPosition = 0
            Me.pageLayoutTabItem.Panel.TabIndex = 3
            Me.pageLayoutTabItem.Panel.Text = "Page Layout"
            Me.pageLayoutTabItem.Size = New System.Drawing.Size(89, 24)
            Me.pageLayoutTabItem.Text = "Page Layout"
            '
            'themesToolStripExt
            '
            Me.themesToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.themesToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.themesToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.themesToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.themesToolStripExt.Image = CType(resources.GetObject("themesToolStripExt.Image"), System.Drawing.Image)
            Me.themesToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.themesToolStripDropDwnBtn, Me.toolStripPanelItem13})
            Me.themesToolStripExt.Location = New System.Drawing.Point(0, 1)
            Me.themesToolStripExt.Name = "themesToolStripExt"
            Me.themesToolStripExt.ShowLauncher = False
            Me.themesToolStripExt.Size = New System.Drawing.Size(93, 0)
            Me.themesToolStripExt.TabIndex = 0
            Me.themesToolStripExt.Text = "Themes"
            '
            'themesToolStripDropDwnBtn
            '
            Me.themesToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.resetToThemeFromTemplateToolStripMenuItem, Me.searchOfficeOnlineToolStripMenuItem, Me.browseForThemesToolStripMenuItem, Me.saveCurrentThemeToolStripMenuItem})
            Me.themesToolStripDropDwnBtn.Image = CType(resources.GetObject("themesToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.themesToolStripDropDwnBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.themesToolStripDropDwnBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.themesToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.themesToolStripDropDwnBtn.Name = "themesToolStripDropDwnBtn"
            Me.themesToolStripDropDwnBtn.Size = New System.Drawing.Size(57, 0)
            Me.themesToolStripDropDwnBtn.Text = "Themes"
            Me.themesToolStripDropDwnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo95.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo95.Body.Hidden = True
            ToolTipInfo95.Footer.Hidden = True
            ToolTipInfo95.Header.Text = "Themes"
            ToolTipInfo95.Separator = False
            Me.superToolTip1.SetToolTip(Me.themesToolStripDropDwnBtn, ToolTipInfo95)
            '
            'resetToThemeFromTemplateToolStripMenuItem
            '
            Me.resetToThemeFromTemplateToolStripMenuItem.Name = "resetToThemeFromTemplateToolStripMenuItem"
            Me.resetToThemeFromTemplateToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
            Me.resetToThemeFromTemplateToolStripMenuItem.Text = "&Reset to Theme from Template"
            '
            'searchOfficeOnlineToolStripMenuItem
            '
            Me.searchOfficeOnlineToolStripMenuItem.Name = "searchOfficeOnlineToolStripMenuItem"
            Me.searchOfficeOnlineToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
            Me.searchOfficeOnlineToolStripMenuItem.Text = "Search &Office Online..."
            '
            'browseForThemesToolStripMenuItem
            '
            Me.browseForThemesToolStripMenuItem.Name = "browseForThemesToolStripMenuItem"
            Me.browseForThemesToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
            Me.browseForThemesToolStripMenuItem.Text = "&Browse for Themes..."
            '
            'saveCurrentThemeToolStripMenuItem
            '
            Me.saveCurrentThemeToolStripMenuItem.Name = "saveCurrentThemeToolStripMenuItem"
            Me.saveCurrentThemeToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
            Me.saveCurrentThemeToolStripMenuItem.Text = "S&ave Current Theme..."
            '
            'toolStripPanelItem13
            '
            Me.toolStripPanelItem13.AutoSize = False
            Me.toolStripPanelItem13.CausesValidation = False
            Me.toolStripPanelItem13.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem13.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.themeColorToolStripDropDwnBtn, Me.themeFontToolStripDropDwnBtn, Me.themeEffectsToolStripDropDwnBtn})
            Me.toolStripPanelItem13.Name = "toolStripPanelItem13"
            Me.toolStripPanelItem13.Size = New System.Drawing.Size(29, 72)
            Me.toolStripPanelItem13.Text = "toolStripPanelItem13"
            Me.toolStripPanelItem13.Transparent = True
            '
            'themeColorToolStripDropDwnBtn
            '
            Me.themeColorToolStripDropDwnBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.themeColorToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.createNewThemeColorsToolStripMenuItem1})
            Me.themeColorToolStripDropDwnBtn.Image = CType(resources.GetObject("themeColorToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.themeColorToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.themeColorToolStripDropDwnBtn.Name = "themeColorToolStripDropDwnBtn"
            Me.themeColorToolStripDropDwnBtn.Size = New System.Drawing.Size(29, 20)
            Me.themeColorToolStripDropDwnBtn.Text = "themeColorToolStripDropDwnBtn"
            ToolTipInfo96.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo96.Body.Hidden = True
            ToolTipInfo96.Footer.Hidden = True
            ToolTipInfo96.Header.Text = "Theme Color"
            ToolTipInfo96.Separator = False
            Me.superToolTip1.SetToolTip(Me.themeColorToolStripDropDwnBtn, ToolTipInfo96)
            '
            'createNewThemeColorsToolStripMenuItem1
            '
            Me.createNewThemeColorsToolStripMenuItem1.Name = "createNewThemeColorsToolStripMenuItem1"
            Me.createNewThemeColorsToolStripMenuItem1.Size = New System.Drawing.Size(222, 22)
            Me.createNewThemeColorsToolStripMenuItem1.Text = "&Create New Theme Colors..."
            '
            'themeFontToolStripDropDwnBtn
            '
            Me.themeFontToolStripDropDwnBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.themeFontToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.createNewThemeFontsToolStripMenuItem1})
            Me.themeFontToolStripDropDwnBtn.Image = CType(resources.GetObject("themeFontToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.themeFontToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.themeFontToolStripDropDwnBtn.Name = "themeFontToolStripDropDwnBtn"
            Me.themeFontToolStripDropDwnBtn.Size = New System.Drawing.Size(29, 20)
            Me.themeFontToolStripDropDwnBtn.Text = "themeFontToolStripDropDwnBtn"
            ToolTipInfo97.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo97.Body.Hidden = True
            ToolTipInfo97.Footer.Hidden = True
            ToolTipInfo97.Header.Text = "Theme Font"
            ToolTipInfo97.Separator = False
            Me.superToolTip1.SetToolTip(Me.themeFontToolStripDropDwnBtn, ToolTipInfo97)
            '
            'createNewThemeFontsToolStripMenuItem1
            '
            Me.createNewThemeFontsToolStripMenuItem1.Name = "createNewThemeFontsToolStripMenuItem1"
            Me.createNewThemeFontsToolStripMenuItem1.Size = New System.Drawing.Size(219, 22)
            Me.createNewThemeFontsToolStripMenuItem1.Text = "&Create New Theme Fonts..."
            '
            'themeEffectsToolStripDropDwnBtn
            '
            Me.themeEffectsToolStripDropDwnBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.themeEffectsToolStripDropDwnBtn.Image = CType(resources.GetObject("themeEffectsToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.themeEffectsToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.themeEffectsToolStripDropDwnBtn.Name = "themeEffectsToolStripDropDwnBtn"
            Me.themeEffectsToolStripDropDwnBtn.Size = New System.Drawing.Size(29, 20)
            Me.themeEffectsToolStripDropDwnBtn.Text = "themeEffectsToolStripDropDwnBtn"
            ToolTipInfo98.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo98.Body.Hidden = True
            ToolTipInfo98.Footer.Hidden = True
            ToolTipInfo98.Header.Text = "Theme Effects"
            ToolTipInfo98.Separator = False
            Me.superToolTip1.SetToolTip(Me.themeEffectsToolStripDropDwnBtn, ToolTipInfo98)
            '
            'pageSetupToolStripExt
            '
            Me.pageSetupToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.pageSetupToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.pageSetupToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.pageSetupToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.pageSetupToolStripExt.Image = CType(resources.GetObject("pageSetupToolStripExt.Image"), System.Drawing.Image)
            Me.pageSetupToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.marginToolStripDropDwnBtn, Me.toolStripPanelItem44, Me.toolStripPanelItem14})
            Me.pageSetupToolStripExt.Location = New System.Drawing.Point(93, 1)
            Me.pageSetupToolStripExt.Name = "pageSetupToolStripExt"
            Me.pageSetupToolStripExt.Size = New System.Drawing.Size(265, 0)
            Me.pageSetupToolStripExt.TabIndex = 1
            Me.pageSetupToolStripExt.Text = "Page Setup"
            ToolTipInfo106.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo106.Header.Text = "Page Setup"
            Me.superToolTip1.SetToolTip(Me.pageSetupToolStripExt, ToolTipInfo106)
            '
            'marginToolStripDropDwnBtn
            '
            Me.marginToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.customMarginsToolStripMenuItem})
            Me.marginToolStripDropDwnBtn.Image = CType(resources.GetObject("marginToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.marginToolStripDropDwnBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.marginToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.marginToolStripDropDwnBtn.Name = "marginToolStripDropDwnBtn"
            Me.marginToolStripDropDwnBtn.Size = New System.Drawing.Size(57, 0)
            Me.marginToolStripDropDwnBtn.Text = "Margins"
            Me.marginToolStripDropDwnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo99.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo99.Body.Hidden = True
            ToolTipInfo99.Footer.Hidden = True
            ToolTipInfo99.Header.Text = "Margins"
            ToolTipInfo99.Separator = False
            Me.superToolTip1.SetToolTip(Me.marginToolStripDropDwnBtn, ToolTipInfo99)
            '
            'customMarginsToolStripMenuItem
            '
            Me.customMarginsToolStripMenuItem.Name = "customMarginsToolStripMenuItem"
            Me.customMarginsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
            Me.customMarginsToolStripMenuItem.Text = "Custom M&argins..."
            '
            'toolStripPanelItem44
            '
            Me.toolStripPanelItem44.CausesValidation = False
            Me.toolStripPanelItem44.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem44.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.orientationToolStripDropDwnBtn, Me.sizeToolStripDropDwnBtn, Me.columnsToolStripDropDwnBtn})
            Me.toolStripPanelItem44.Name = "toolStripPanelItem44"
            Me.toolStripPanelItem44.Size = New System.Drawing.Size(94, 0)
            Me.toolStripPanelItem44.Text = "toolStripPanelItem44"
            Me.toolStripPanelItem44.Transparent = True
            '
            'orientationToolStripDropDwnBtn
            '
            Me.orientationToolStripDropDwnBtn.Image = CType(resources.GetObject("orientationToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.orientationToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.orientationToolStripDropDwnBtn.Name = "orientationToolStripDropDwnBtn"
            Me.orientationToolStripDropDwnBtn.Size = New System.Drawing.Size(90, 20)
            Me.orientationToolStripDropDwnBtn.Text = "Orientation"
            ToolTipInfo100.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo100.Body.Hidden = True
            ToolTipInfo100.Footer.Hidden = True
            ToolTipInfo100.Header.Text = "Orientation"
            ToolTipInfo100.Separator = False
            Me.superToolTip1.SetToolTip(Me.orientationToolStripDropDwnBtn, ToolTipInfo100)
            '
            'sizeToolStripDropDwnBtn
            '
            Me.sizeToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.morePaperSizesToolStripMenuItem})
            Me.sizeToolStripDropDwnBtn.Image = CType(resources.GetObject("sizeToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.sizeToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.sizeToolStripDropDwnBtn.Name = "sizeToolStripDropDwnBtn"
            Me.sizeToolStripDropDwnBtn.Size = New System.Drawing.Size(55, 20)
            Me.sizeToolStripDropDwnBtn.Text = "Size"
            ToolTipInfo101.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo101.Body.Hidden = True
            ToolTipInfo101.Footer.Hidden = True
            ToolTipInfo101.Header.Text = "Size"
            ToolTipInfo101.Separator = False
            Me.superToolTip1.SetToolTip(Me.sizeToolStripDropDwnBtn, ToolTipInfo101)
            '
            'morePaperSizesToolStripMenuItem
            '
            Me.morePaperSizesToolStripMenuItem.Name = "morePaperSizesToolStripMenuItem"
            Me.morePaperSizesToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
            Me.morePaperSizesToolStripMenuItem.Text = "More P&aper Sizes..."
            '
            'columnsToolStripDropDwnBtn
            '
            Me.columnsToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.moreColumnsToolStripMenuItem})
            Me.columnsToolStripDropDwnBtn.Image = CType(resources.GetObject("columnsToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.columnsToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.columnsToolStripDropDwnBtn.Name = "columnsToolStripDropDwnBtn"
            Me.columnsToolStripDropDwnBtn.Size = New System.Drawing.Size(76, 20)
            Me.columnsToolStripDropDwnBtn.Text = "Columns"
            ToolTipInfo102.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo102.Body.Hidden = True
            ToolTipInfo102.Footer.Hidden = True
            ToolTipInfo102.Header.Text = "Columns"
            ToolTipInfo102.Separator = False
            Me.superToolTip1.SetToolTip(Me.columnsToolStripDropDwnBtn, ToolTipInfo102)
            '
            'moreColumnsToolStripMenuItem
            '
            Me.moreColumnsToolStripMenuItem.Name = "moreColumnsToolStripMenuItem"
            Me.moreColumnsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
            Me.moreColumnsToolStripMenuItem.Text = "More &Columns..."
            '
            'toolStripPanelItem14
            '
            Me.toolStripPanelItem14.CausesValidation = False
            Me.toolStripPanelItem14.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem14.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.breaksToolStripDropDwnBtn, Me.lnumbersToolStripDropDwnBtn, Me.hyphenationToolStripDropDwnBtn})
            Me.toolStripPanelItem14.Name = "toolStripPanelItem14"
            Me.toolStripPanelItem14.Size = New System.Drawing.Size(104, 0)
            Me.toolStripPanelItem14.Text = "toolStripPanelItem14"
            Me.toolStripPanelItem14.Transparent = True
            '
            'breaksToolStripDropDwnBtn
            '
            Me.breaksToolStripDropDwnBtn.Image = CType(resources.GetObject("breaksToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.breaksToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.breaksToolStripDropDwnBtn.Name = "breaksToolStripDropDwnBtn"
            Me.breaksToolStripDropDwnBtn.Size = New System.Drawing.Size(68, 20)
            Me.breaksToolStripDropDwnBtn.Text = "Breaks"
            ToolTipInfo103.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo103.Body.Hidden = True
            ToolTipInfo103.Footer.Hidden = True
            ToolTipInfo103.Header.Text = "Breaks"
            ToolTipInfo103.Separator = False
            Me.superToolTip1.SetToolTip(Me.breaksToolStripDropDwnBtn, ToolTipInfo103)
            '
            'lnumbersToolStripDropDwnBtn
            '
            Me.lnumbersToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.noneToolStripMenuItem, Me.continuousToolStripMenuItem, Me.restartEachPageToolStripMenuItem, Me.restartEachSectionToolStripMenuItem, Me.suppressForCurrentSectionToolStripMenuItem, Me.toolStripSeparator11, Me.moreLineNumberingToolStripMenuItem})
            Me.lnumbersToolStripDropDwnBtn.Image = CType(resources.GetObject("lnumbersToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.lnumbersToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.lnumbersToolStripDropDwnBtn.Name = "lnumbersToolStripDropDwnBtn"
            Me.lnumbersToolStripDropDwnBtn.Size = New System.Drawing.Size(100, 20)
            Me.lnumbersToolStripDropDwnBtn.Text = "Line Numbers"
            ToolTipInfo104.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo104.Header.Text = "Line Numbers"
            Me.superToolTip1.SetToolTip(Me.lnumbersToolStripDropDwnBtn, ToolTipInfo104)
            '
            'noneToolStripMenuItem
            '
            Me.noneToolStripMenuItem.Checked = True
            Me.noneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.noneToolStripMenuItem.Name = "noneToolStripMenuItem"
            Me.noneToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
            Me.noneToolStripMenuItem.Text = "&None"
            '
            'continuousToolStripMenuItem
            '
            Me.continuousToolStripMenuItem.Name = "continuousToolStripMenuItem"
            Me.continuousToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
            Me.continuousToolStripMenuItem.Text = "&Continuous"
            '
            'restartEachPageToolStripMenuItem
            '
            Me.restartEachPageToolStripMenuItem.Name = "restartEachPageToolStripMenuItem"
            Me.restartEachPageToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
            Me.restartEachPageToolStripMenuItem.Text = "&Restart Each Page"
            '
            'restartEachSectionToolStripMenuItem
            '
            Me.restartEachSectionToolStripMenuItem.Name = "restartEachSectionToolStripMenuItem"
            Me.restartEachSectionToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
            Me.restartEachSectionToolStripMenuItem.Text = "R&estart Each Section"
            '
            'suppressForCurrentSectionToolStripMenuItem
            '
            Me.suppressForCurrentSectionToolStripMenuItem.Name = "suppressForCurrentSectionToolStripMenuItem"
            Me.suppressForCurrentSectionToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
            Me.suppressForCurrentSectionToolStripMenuItem.Text = "&Suppress for Current Section"
            '
            'toolStripSeparator11
            '
            Me.toolStripSeparator11.Name = "toolStripSeparator11"
            Me.toolStripSeparator11.Size = New System.Drawing.Size(221, 6)
            '
            'moreLineNumberingToolStripMenuItem
            '
            Me.moreLineNumberingToolStripMenuItem.Name = "moreLineNumberingToolStripMenuItem"
            Me.moreLineNumberingToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
            Me.moreLineNumberingToolStripMenuItem.Text = "&More Line Numbering..."
            '
            'hyphenationToolStripDropDwnBtn
            '
            Me.hyphenationToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.noneToolStripMenuItem1, Me.automaticToolStripMenuItem2, Me.manualToolStripMenuItem, Me.toolStripSeparator12, Me.hyphenationOptionsToolStripMenuItem})
            Me.hyphenationToolStripDropDwnBtn.Image = CType(resources.GetObject("hyphenationToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.hyphenationToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.hyphenationToolStripDropDwnBtn.Name = "hyphenationToolStripDropDwnBtn"
            Me.hyphenationToolStripDropDwnBtn.Size = New System.Drawing.Size(97, 20)
            Me.hyphenationToolStripDropDwnBtn.Text = "Hyphenation"
            ToolTipInfo105.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo105.Header.Text = "Hyphenation"
            Me.superToolTip1.SetToolTip(Me.hyphenationToolStripDropDwnBtn, ToolTipInfo105)
            '
            'noneToolStripMenuItem1
            '
            Me.noneToolStripMenuItem1.Checked = True
            Me.noneToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.noneToolStripMenuItem1.Name = "noneToolStripMenuItem1"
            Me.noneToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
            Me.noneToolStripMenuItem1.Text = "&None"
            '
            'automaticToolStripMenuItem2
            '
            Me.automaticToolStripMenuItem2.Name = "automaticToolStripMenuItem2"
            Me.automaticToolStripMenuItem2.Size = New System.Drawing.Size(198, 22)
            Me.automaticToolStripMenuItem2.Text = "A&utomatic"
            '
            'manualToolStripMenuItem
            '
            Me.manualToolStripMenuItem.Name = "manualToolStripMenuItem"
            Me.manualToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
            Me.manualToolStripMenuItem.Text = "&Manual"
            '
            'toolStripSeparator12
            '
            Me.toolStripSeparator12.Name = "toolStripSeparator12"
            Me.toolStripSeparator12.Size = New System.Drawing.Size(195, 6)
            '
            'hyphenationOptionsToolStripMenuItem
            '
            Me.hyphenationOptionsToolStripMenuItem.Name = "hyphenationOptionsToolStripMenuItem"
            Me.hyphenationOptionsToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
            Me.hyphenationOptionsToolStripMenuItem.Text = "&Hyphenation Options..."
            '
            'pageBackgroundToolStripExt
            '
            Me.pageBackgroundToolStripExt.AutoSize = False
            Me.pageBackgroundToolStripExt.Size = New System.Drawing.Size(129, 86)
            Me.pageBackgroundToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.Right
            Me.pageBackgroundToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.pageBackgroundToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.pageBackgroundToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.pageBackgroundToolStripExt.Image = CType(resources.GetObject("pageBackgroundToolStripExt.Image"), System.Drawing.Image)
            Me.pageBackgroundToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.watermarkToolStripDropDwnBtn, Me.pageColorToolStripDropDwnBtn, Me.pageBordersToolStripBtn})
            Me.pageBackgroundToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.pageBackgroundToolStripExt.Location = New System.Drawing.Point(358, 1)
            Me.pageBackgroundToolStripExt.Name = "pageBackgroundToolStripExt"
            Me.pageBackgroundToolStripExt.ShowLauncher = False
            Me.pageBackgroundToolStripExt.TabIndex = 2
            Me.pageBackgroundToolStripExt.Text = "Page Background"
            '
            'watermarkToolStripDropDwnBtn
            '
            Me.watermarkToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.moreWatermarksToolStripMenuItem, Me.removeWatermartToolStripMenuItem, Me.saveSelectionToWatermarkGalleryToolStripMenuItem})
            Me.watermarkToolStripDropDwnBtn.Image = CType(resources.GetObject("watermarkToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.watermarkToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.watermarkToolStripDropDwnBtn.Name = "watermarkToolStripDropDwnBtn"
            Me.watermarkToolStripDropDwnBtn.Size = New System.Drawing.Size(89, 20)
            Me.watermarkToolStripDropDwnBtn.Text = "Watermark"
            ToolTipInfo107.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo107.Body.Hidden = True
            ToolTipInfo107.Footer.Hidden = True
            ToolTipInfo107.Header.Text = "Watermark"
            ToolTipInfo107.Separator = False
            Me.superToolTip1.SetToolTip(Me.watermarkToolStripDropDwnBtn, ToolTipInfo107)
            '
            'moreWatermarksToolStripMenuItem
            '
            Me.moreWatermarksToolStripMenuItem.Name = "moreWatermarksToolStripMenuItem"
            Me.moreWatermarksToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
            Me.moreWatermarksToolStripMenuItem.Text = "More &Watermarks..."
            '
            'removeWatermartToolStripMenuItem
            '
            Me.removeWatermartToolStripMenuItem.Name = "removeWatermartToolStripMenuItem"
            Me.removeWatermartToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
            Me.removeWatermartToolStripMenuItem.Text = "&Remove Watermark"
            '
            'saveSelectionToWatermarkGalleryToolStripMenuItem
            '
            Me.saveSelectionToWatermarkGalleryToolStripMenuItem.Name = "saveSelectionToWatermarkGalleryToolStripMenuItem"
            Me.saveSelectionToWatermarkGalleryToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
            Me.saveSelectionToWatermarkGalleryToolStripMenuItem.Text = "&Save Selection to Watermark Gallery..."
            '
            'pageColorToolStripDropDwnBtn
            '
            Me.pageColorToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.noColorToolStripMenuItem2, Me.toolStripSeparator13, Me.moreColorsToolStripMenuItem2, Me.fillEffectsToolStripMenuItem})
            Me.pageColorToolStripDropDwnBtn.Image = CType(resources.GetObject("pageColorToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.pageColorToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.pageColorToolStripDropDwnBtn.Name = "pageColorToolStripDropDwnBtn"
            Me.pageColorToolStripDropDwnBtn.Size = New System.Drawing.Size(88, 20)
            Me.pageColorToolStripDropDwnBtn.Text = "Page Color"
            ToolTipInfo108.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo108.Body.Hidden = True
            ToolTipInfo108.Footer.Hidden = True
            ToolTipInfo108.Header.Text = "Page Color"
            ToolTipInfo108.Separator = False
            Me.superToolTip1.SetToolTip(Me.pageColorToolStripDropDwnBtn, ToolTipInfo108)
            '
            'noColorToolStripMenuItem2
            '
            Me.noColorToolStripMenuItem2.Name = "noColorToolStripMenuItem2"
            Me.noColorToolStripMenuItem2.Size = New System.Drawing.Size(154, 22)
            Me.noColorToolStripMenuItem2.Text = "&No Color"
            '
            'toolStripSeparator13
            '
            Me.toolStripSeparator13.Name = "toolStripSeparator13"
            Me.toolStripSeparator13.Size = New System.Drawing.Size(151, 6)
            '
            'moreColorsToolStripMenuItem2
            '
            Me.moreColorsToolStripMenuItem2.Name = "moreColorsToolStripMenuItem2"
            Me.moreColorsToolStripMenuItem2.Size = New System.Drawing.Size(154, 22)
            Me.moreColorsToolStripMenuItem2.Text = "&More Colors..."
            '
            'fillEffectsToolStripMenuItem
            '
            Me.fillEffectsToolStripMenuItem.Name = "fillEffectsToolStripMenuItem"
            Me.fillEffectsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
            Me.fillEffectsToolStripMenuItem.Text = "&Fill Effects..."
            '
            'pageBordersToolStripBtn
            '
            Me.pageBordersToolStripBtn.Image = CType(resources.GetObject("pageBordersToolStripBtn.Image"), System.Drawing.Image)
            Me.pageBordersToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.pageBordersToolStripBtn.Name = "pageBordersToolStripBtn"
            Me.pageBordersToolStripBtn.Size = New System.Drawing.Size(91, 20)
            Me.pageBordersToolStripBtn.Text = "Page Borders"
            ToolTipInfo109.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo109.Body.Hidden = True
            ToolTipInfo109.Footer.Hidden = True
            ToolTipInfo109.Header.Text = "Page Borders"
            ToolTipInfo109.Separator = False
            Me.superToolTip1.SetToolTip(Me.pageBordersToolStripBtn, ToolTipInfo109)
            '
            'paraToolStripExt
            '
            Me.paraToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.paraToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.paraToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.paraToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.paraToolStripExt.Image = CType(resources.GetObject("paraToolStripExt.Image"), System.Drawing.Image)
            Me.paraToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem17, Me.toolStripSeparator7, Me.toolStripPanelItem18})
            Me.paraToolStripExt.Location = New System.Drawing.Point(463, 1)
            Me.paraToolStripExt.Name = "paraToolStripExt"
            Me.paraToolStripExt.Size = New System.Drawing.Size(247, 0)
            Me.paraToolStripExt.TabIndex = 3
            Me.paraToolStripExt.Text = "Paragraph"
            ToolTipInfo114.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo114.Header.Text = "Paragraph"
            Me.superToolTip1.SetToolTip(Me.paraToolStripExt, ToolTipInfo114)
            '
            'toolStripPanelItem17
            '
            Me.toolStripPanelItem17.CausesValidation = False
            Me.toolStripPanelItem17.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem17.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.indentToolStripLabel, Me.toolStripPanelItem19, Me.toolStripPanelItem20})
            Me.toolStripPanelItem17.Name = "toolStripPanelItem17"
            Me.toolStripPanelItem17.Size = New System.Drawing.Size(110, 0)
            Me.toolStripPanelItem17.Text = "toolStripPanelItem17"
            Me.toolStripPanelItem17.Transparent = True
            '
            'indentToolStripLabel
            '
            Me.indentToolStripLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.indentToolStripLabel.Name = "indentToolStripLabel"
            Me.indentToolStripLabel.Size = New System.Drawing.Size(39, 13)
            Me.indentToolStripLabel.Text = "Indent"
            '
            'toolStripPanelItem19
            '
            Me.toolStripPanelItem19.CausesValidation = False
            Me.toolStripPanelItem19.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem19.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lindentToolStripLabel, Me.ToolStriplindentComboBox})
            Me.toolStripPanelItem19.Name = "toolStripPanelItem19"
            Me.toolStripPanelItem19.RowCount = 1
            Me.toolStripPanelItem19.Size = New System.Drawing.Size(104, 25)
            Me.toolStripPanelItem19.Text = "toolStripPanelItem19"
            Me.toolStripPanelItem19.Transparent = True
            '
            'lindentToolStripLabel
            '
            Me.lindentToolStripLabel.AutoSize = False
            Me.lindentToolStripLabel.Image = CType(resources.GetObject("lindentToolStripLabel.Image"), System.Drawing.Image)
            Me.lindentToolStripLabel.Name = "lindentToolStripLabel"
            Me.lindentToolStripLabel.Size = New System.Drawing.Size(48, 16)
            Me.lindentToolStripLabel.Text = "Left"
            ToolTipInfo110.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo110.Header.Text = "Left Indent"
            Me.superToolTip1.SetToolTip(Me.lindentToolStripLabel, ToolTipInfo110)
            '
            'ToolStriplindentComboBox
            '
            Me.ToolStriplindentComboBox.AutoSize = False
            Me.ToolStriplindentComboBox.Name = "ToolStriplindentComboBox"
            Me.ToolStriplindentComboBox.Size = New System.Drawing.Size(50, 21)
            '
            'toolStripPanelItem20
            '
            Me.toolStripPanelItem20.CausesValidation = False
            Me.toolStripPanelItem20.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem20.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rindentToolStripLabel, Me.ToolStriprindentComboBox})
            Me.toolStripPanelItem20.Name = "toolStripPanelItem20"
            Me.toolStripPanelItem20.RowCount = 1
            Me.toolStripPanelItem20.Size = New System.Drawing.Size(104, 25)
            Me.toolStripPanelItem20.Text = "toolStripPanelItem20"
            Me.toolStripPanelItem20.Transparent = True
            '
            'rindentToolStripLabel
            '
            Me.rindentToolStripLabel.Image = CType(resources.GetObject("rindentToolStripLabel.Image"), System.Drawing.Image)
            Me.rindentToolStripLabel.Name = "rindentToolStripLabel"
            Me.rindentToolStripLabel.Size = New System.Drawing.Size(48, 16)
            Me.rindentToolStripLabel.Text = "Right"
            ToolTipInfo111.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo111.Header.Text = "Right Indent"
            Me.superToolTip1.SetToolTip(Me.rindentToolStripLabel, ToolTipInfo111)
            '
            'ToolStriprindentComboBox
            '
            Me.ToolStriprindentComboBox.AutoSize = False
            Me.ToolStriprindentComboBox.Name = "ToolStriprindentComboBox"
            Me.ToolStriprindentComboBox.Size = New System.Drawing.Size(50, 21)
            '
            'toolStripSeparator7
            '
            Me.toolStripSeparator7.Name = "toolStripSeparator7"
            Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 0)
            '
            'toolStripPanelItem18
            '
            Me.toolStripPanelItem18.CausesValidation = False
            Me.toolStripPanelItem18.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem18.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.spacingToolStripLabel, Me.toolStripPanelItem21, Me.toolStripPanelItem22})
            Me.toolStripPanelItem18.Name = "toolStripPanelItem18"
            Me.toolStripPanelItem18.Size = New System.Drawing.Size(122, 0)
            Me.toolStripPanelItem18.Text = "toolStripPanelItem18"
            Me.toolStripPanelItem18.Transparent = True
            '
            'spacingToolStripLabel
            '
            Me.spacingToolStripLabel.Name = "spacingToolStripLabel"
            Me.spacingToolStripLabel.Size = New System.Drawing.Size(44, 13)
            Me.spacingToolStripLabel.Text = "Spacing"
            '
            'toolStripPanelItem21
            '
            Me.toolStripPanelItem21.CausesValidation = False
            Me.toolStripPanelItem21.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem21.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbeforeToolStripLabel, Me.ToolStripsbeforeComboBox})
            Me.toolStripPanelItem21.Name = "toolStripPanelItem21"
            Me.toolStripPanelItem21.RowCount = 1
            Me.toolStripPanelItem21.Size = New System.Drawing.Size(116, 27)
            Me.toolStripPanelItem21.Text = "toolStripPanelItem21"
            Me.toolStripPanelItem21.Transparent = True
            '
            'sbeforeToolStripLabel
            '
            Me.sbeforeToolStripLabel.Image = CType(resources.GetObject("sbeforeToolStripLabel.Image"), System.Drawing.Image)
            Me.sbeforeToolStripLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.sbeforeToolStripLabel.ImageTransparentColor = System.Drawing.Color.White
            Me.sbeforeToolStripLabel.Name = "sbeforeToolStripLabel"
            Me.sbeforeToolStripLabel.Size = New System.Drawing.Size(60, 20)
            Me.sbeforeToolStripLabel.Text = "Before"
            ToolTipInfo112.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo112.Header.Text = "Spacing Before"
            Me.superToolTip1.SetToolTip(Me.sbeforeToolStripLabel, ToolTipInfo112)
            '
            'ToolStripsbeforeComboBox
            '
            Me.ToolStripsbeforeComboBox.AutoSize = False
            Me.ToolStripsbeforeComboBox.Name = "ToolStripsbeforeComboBox"
            Me.ToolStripsbeforeComboBox.Size = New System.Drawing.Size(50, 21)
            '
            'toolStripPanelItem22
            '
            Me.toolStripPanelItem22.CausesValidation = False
            Me.toolStripPanelItem22.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem22.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.safterToolStripLabel, Me.ToolStripsafterComboBox})
            Me.toolStripPanelItem22.Name = "toolStripPanelItem22"
            Me.toolStripPanelItem22.RowCount = 1
            Me.toolStripPanelItem22.Size = New System.Drawing.Size(116, 27)
            Me.toolStripPanelItem22.Text = "toolStripPanelItem22"
            Me.toolStripPanelItem22.Transparent = True
            '
            'safterToolStripLabel
            '
            Me.safterToolStripLabel.AutoSize = False
            Me.safterToolStripLabel.Image = CType(resources.GetObject("safterToolStripLabel.Image"), System.Drawing.Image)
            Me.safterToolStripLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.safterToolStripLabel.ImageTransparentColor = System.Drawing.Color.White
            Me.safterToolStripLabel.Name = "safterToolStripLabel"
            Me.safterToolStripLabel.Size = New System.Drawing.Size(60, 20)
            Me.safterToolStripLabel.Text = "After"
            ToolTipInfo113.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo113.Header.Text = "Spacing After"
            Me.superToolTip1.SetToolTip(Me.safterToolStripLabel, ToolTipInfo113)
            '
            'ToolStripsafterComboBox
            '
            Me.ToolStripsafterComboBox.AutoSize = False
            Me.ToolStripsafterComboBox.Name = "ToolStripsafterComboBox"
            Me.ToolStripsafterComboBox.Size = New System.Drawing.Size(50, 21)
            '
            'arrangeToolStripExt
            '
            Me.arrangeToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.arrangeToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.arrangeToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.arrangeToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.arrangeToolStripExt.Image = CType(resources.GetObject("arrangeToolStripExt.Image"), System.Drawing.Image)
            Me.arrangeToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.positionToolStripDropDwnBtn, Me.toolStripPanelItem23, Me.toolStripPanelItem24})
            Me.arrangeToolStripExt.Location = New System.Drawing.Point(710, 1)
            Me.arrangeToolStripExt.Name = "arrangeToolStripExt"
            Me.arrangeToolStripExt.ShowLauncher = False
            Me.arrangeToolStripExt.Size = New System.Drawing.Size(265, 0)
            Me.arrangeToolStripExt.TabIndex = 4
            Me.arrangeToolStripExt.Text = "Arrange"
            '
            'positionToolStripDropDwnBtn
            '
            Me.positionToolStripDropDwnBtn.Enabled = False
            Me.positionToolStripDropDwnBtn.Image = CType(resources.GetObject("positionToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.positionToolStripDropDwnBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.positionToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.positionToolStripDropDwnBtn.Name = "positionToolStripDropDwnBtn"
            Me.positionToolStripDropDwnBtn.Size = New System.Drawing.Size(57, 0)
            Me.positionToolStripDropDwnBtn.Text = "Position"
            Me.positionToolStripDropDwnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo115.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo115.Body.Hidden = True
            ToolTipInfo115.Footer.Hidden = True
            ToolTipInfo115.Header.Text = "Position"
            ToolTipInfo115.Separator = False
            Me.superToolTip1.SetToolTip(Me.positionToolStripDropDwnBtn, ToolTipInfo115)
            '
            'toolStripPanelItem23
            '
            Me.toolStripPanelItem23.CausesValidation = False
            Me.toolStripPanelItem23.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem23.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bringToFrontToolStripSplitBtn, Me.sendToBackToolStripSplitBtn, Me.txtwrapToolStripSplitBtn})
            Me.toolStripPanelItem23.Name = "toolStripPanelItem23"
            Me.toolStripPanelItem23.Size = New System.Drawing.Size(114, 0)
            Me.toolStripPanelItem23.Text = "toolStripPanelItem23"
            Me.toolStripPanelItem23.Transparent = True
            '
            'bringToFrontToolStripSplitBtn
            '
            Me.bringToFrontToolStripSplitBtn.Enabled = False
            Me.bringToFrontToolStripSplitBtn.Image = CType(resources.GetObject("bringToFrontToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.bringToFrontToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bringToFrontToolStripSplitBtn.Name = "bringToFrontToolStripSplitBtn"
            Me.bringToFrontToolStripSplitBtn.Size = New System.Drawing.Size(107, 20)
            Me.bringToFrontToolStripSplitBtn.Text = "Bring To Front"
            ToolTipInfo116.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo116.Body.Hidden = True
            ToolTipInfo116.Footer.Hidden = True
            ToolTipInfo116.Header.Text = "Bring To Front"
            ToolTipInfo116.Separator = False
            Me.superToolTip1.SetToolTip(Me.bringToFrontToolStripSplitBtn, ToolTipInfo116)
            '
            'sendToBackToolStripSplitBtn
            '
            Me.sendToBackToolStripSplitBtn.Enabled = False
            Me.sendToBackToolStripSplitBtn.Image = CType(resources.GetObject("sendToBackToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.sendToBackToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.sendToBackToolStripSplitBtn.Name = "sendToBackToolStripSplitBtn"
            Me.sendToBackToolStripSplitBtn.Size = New System.Drawing.Size(103, 20)
            Me.sendToBackToolStripSplitBtn.Text = "Send To Back"
            ToolTipInfo117.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo117.Body.Hidden = True
            ToolTipInfo117.Footer.Hidden = True
            ToolTipInfo117.Header.Text = "Send To Back"
            ToolTipInfo117.Separator = False
            Me.superToolTip1.SetToolTip(Me.sendToBackToolStripSplitBtn, ToolTipInfo117)
            '
            'txtwrapToolStripSplitBtn
            '
            Me.txtwrapToolStripSplitBtn.Enabled = False
            Me.txtwrapToolStripSplitBtn.Image = CType(resources.GetObject("txtwrapToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.txtwrapToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.txtwrapToolStripSplitBtn.Name = "txtwrapToolStripSplitBtn"
            Me.txtwrapToolStripSplitBtn.Size = New System.Drawing.Size(110, 20)
            Me.txtwrapToolStripSplitBtn.Text = "Text Wrapping"
            ToolTipInfo118.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo118.Body.Hidden = True
            ToolTipInfo118.Footer.Hidden = True
            ToolTipInfo118.Header.Text = "Text Wrapping"
            ToolTipInfo118.Separator = False
            Me.superToolTip1.SetToolTip(Me.txtwrapToolStripSplitBtn, ToolTipInfo118)
            '
            'toolStripPanelItem24
            '
            Me.toolStripPanelItem24.CausesValidation = False
            Me.toolStripPanelItem24.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem24.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.alignToolStripSplitBtn, Me.groupToolStripSplitBtn, Me.rotateToolStripSplitBtn})
            Me.toolStripPanelItem24.Name = "toolStripPanelItem24"
            Me.toolStripPanelItem24.Size = New System.Drawing.Size(76, 0)
            Me.toolStripPanelItem24.Text = "toolStripPanelItem24"
            Me.toolStripPanelItem24.Transparent = True
            '
            'alignToolStripSplitBtn
            '
            Me.alignToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.alignLeftToolStripMenuItem, Me.alignCenterToolStripMenuItem, Me.alignRightToolStripMenuItem, Me.toolStripSeparator14, Me.alignTopToolStripMenuItem, Me.alignMiddleToolStripMenuItem, Me.alignBottomToolStripMenuItem, Me.toolStripSeparator17, Me.distributreHorizontallyToolStripMenuItem, Me.distributeToolStripMenuItem, Me.toolStripSeparator15, Me.alignToPageToolStripMenuItem, Me.alToolStripMenuItem, Me.alignSelectedObjectsToolStripMenuItem, Me.toolStripSeparator16, Me.showGridlinesToolStripMenuItem1, Me.gridSettingsToolStripMenuItem})
            Me.alignToolStripSplitBtn.Image = CType(resources.GetObject("alignToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.alignToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.alignToolStripSplitBtn.Name = "alignToolStripSplitBtn"
            Me.alignToolStripSplitBtn.Size = New System.Drawing.Size(62, 20)
            Me.alignToolStripSplitBtn.Text = "Align"
            ToolTipInfo119.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo119.Body.Hidden = True
            ToolTipInfo119.Footer.Hidden = True
            ToolTipInfo119.Header.Text = "Align"
            ToolTipInfo119.Separator = False
            Me.superToolTip1.SetToolTip(Me.alignToolStripSplitBtn, ToolTipInfo119)
            '
            'alignLeftToolStripMenuItem
            '
            Me.alignLeftToolStripMenuItem.Enabled = False
            Me.alignLeftToolStripMenuItem.Name = "alignLeftToolStripMenuItem"
            Me.alignLeftToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
            Me.alignLeftToolStripMenuItem.Text = "Align &Left"
            '
            'alignCenterToolStripMenuItem
            '
            Me.alignCenterToolStripMenuItem.Enabled = False
            Me.alignCenterToolStripMenuItem.Name = "alignCenterToolStripMenuItem"
            Me.alignCenterToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
            Me.alignCenterToolStripMenuItem.Text = "Align &Center"
            '
            'alignRightToolStripMenuItem
            '
            Me.alignRightToolStripMenuItem.Enabled = False
            Me.alignRightToolStripMenuItem.Name = "alignRightToolStripMenuItem"
            Me.alignRightToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
            Me.alignRightToolStripMenuItem.Text = "Align &Right"
            '
            'toolStripSeparator14
            '
            Me.toolStripSeparator14.Name = "toolStripSeparator14"
            Me.toolStripSeparator14.Size = New System.Drawing.Size(189, 6)
            '
            'alignTopToolStripMenuItem
            '
            Me.alignTopToolStripMenuItem.Enabled = False
            Me.alignTopToolStripMenuItem.Name = "alignTopToolStripMenuItem"
            Me.alignTopToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
            Me.alignTopToolStripMenuItem.Text = "Align &Top"
            '
            'alignMiddleToolStripMenuItem
            '
            Me.alignMiddleToolStripMenuItem.Enabled = False
            Me.alignMiddleToolStripMenuItem.Name = "alignMiddleToolStripMenuItem"
            Me.alignMiddleToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
            Me.alignMiddleToolStripMenuItem.Text = "Align &Middle"
            '
            'alignBottomToolStripMenuItem
            '
            Me.alignBottomToolStripMenuItem.Enabled = False
            Me.alignBottomToolStripMenuItem.Name = "alignBottomToolStripMenuItem"
            Me.alignBottomToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
            Me.alignBottomToolStripMenuItem.Text = "Align &Bottom"
            '
            'toolStripSeparator17
            '
            Me.toolStripSeparator17.Name = "toolStripSeparator17"
            Me.toolStripSeparator17.Size = New System.Drawing.Size(189, 6)
            '
            'distributreHorizontallyToolStripMenuItem
            '
            Me.distributreHorizontallyToolStripMenuItem.Enabled = False
            Me.distributreHorizontallyToolStripMenuItem.Name = "distributreHorizontallyToolStripMenuItem"
            Me.distributreHorizontallyToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
            Me.distributreHorizontallyToolStripMenuItem.Text = "Distribute &Horizontally"
            '
            'distributeToolStripMenuItem
            '
            Me.distributeToolStripMenuItem.Enabled = False
            Me.distributeToolStripMenuItem.Name = "distributeToolStripMenuItem"
            Me.distributeToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
            Me.distributeToolStripMenuItem.Text = "Distribute &Vertically"
            '
            'toolStripSeparator15
            '
            Me.toolStripSeparator15.Name = "toolStripSeparator15"
            Me.toolStripSeparator15.Size = New System.Drawing.Size(189, 6)
            '
            'alignToPageToolStripMenuItem
            '
            Me.alignToPageToolStripMenuItem.Checked = True
            Me.alignToPageToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.alignToPageToolStripMenuItem.Name = "alignToPageToolStripMenuItem"
            Me.alignToPageToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
            Me.alignToPageToolStripMenuItem.Text = "Align to &Page"
            '
            'alToolStripMenuItem
            '
            Me.alToolStripMenuItem.Name = "alToolStripMenuItem"
            Me.alToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
            Me.alToolStripMenuItem.Text = "&Align to Margin"
            '
            'alignSelectedObjectsToolStripMenuItem
            '
            Me.alignSelectedObjectsToolStripMenuItem.Enabled = False
            Me.alignSelectedObjectsToolStripMenuItem.Name = "alignSelectedObjectsToolStripMenuItem"
            Me.alignSelectedObjectsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
            Me.alignSelectedObjectsToolStripMenuItem.Text = "Align Selected &Objects"
            '
            'toolStripSeparator16
            '
            Me.toolStripSeparator16.Name = "toolStripSeparator16"
            Me.toolStripSeparator16.Size = New System.Drawing.Size(189, 6)
            '
            'showGridlinesToolStripMenuItem1
            '
            Me.showGridlinesToolStripMenuItem1.Name = "showGridlinesToolStripMenuItem1"
            Me.showGridlinesToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
            Me.showGridlinesToolStripMenuItem1.Text = "&Show Gridlines"
            '
            'gridSettingsToolStripMenuItem
            '
            Me.gridSettingsToolStripMenuItem.Name = "gridSettingsToolStripMenuItem"
            Me.gridSettingsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
            Me.gridSettingsToolStripMenuItem.Text = "&Grid Settings..."
            '
            'groupToolStripSplitBtn
            '
            Me.groupToolStripSplitBtn.Enabled = False
            Me.groupToolStripSplitBtn.Image = CType(resources.GetObject("groupToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.groupToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.groupToolStripSplitBtn.Name = "groupToolStripSplitBtn"
            Me.groupToolStripSplitBtn.Size = New System.Drawing.Size(68, 20)
            Me.groupToolStripSplitBtn.Text = "Group"
            ToolTipInfo120.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo120.Body.Hidden = True
            ToolTipInfo120.Footer.Hidden = True
            ToolTipInfo120.Header.Text = "Group"
            ToolTipInfo120.Separator = False
            Me.superToolTip1.SetToolTip(Me.groupToolStripSplitBtn, ToolTipInfo120)
            '
            'rotateToolStripSplitBtn
            '
            Me.rotateToolStripSplitBtn.Enabled = False
            Me.rotateToolStripSplitBtn.Image = CType(resources.GetObject("rotateToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.rotateToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.rotateToolStripSplitBtn.Name = "rotateToolStripSplitBtn"
            Me.rotateToolStripSplitBtn.Size = New System.Drawing.Size(72, 20)
            Me.rotateToolStripSplitBtn.Text = "Rotate"
            ToolTipInfo121.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo121.Body.Hidden = True
            ToolTipInfo121.Footer.Hidden = True
            ToolTipInfo121.Header.Text = "Rotate"
            ToolTipInfo121.Separator = False
            Me.superToolTip1.SetToolTip(Me.rotateToolStripSplitBtn, ToolTipInfo121)
            '
            'referencesTabItem
            '
            Me.superAccelerator.SetAccelerator(Me.referencesTabItem, "S")
            Me.referencesTabItem.ForeColor = System.Drawing.Color.MidnightBlue
            Me.referencesTabItem.Name = "referencesTabItem"
            Me.referencesTabItem.Padding = New System.Windows.Forms.Padding(15, 2, 3, 5)
            '
            'ribbonControlAdv1.RibbonPanel4
            '
            Me.referencesTabItem.Panel.Controls.Add(Me.tbofContentsToolStripExt)
            Me.referencesTabItem.Panel.Controls.Add(Me.footNotesToolStripExt)
            Me.referencesTabItem.Panel.Controls.Add(Me.citationsToolStripExt)
            Me.referencesTabItem.Panel.Controls.Add(Me.captionsToolStripExt)
            Me.referencesTabItem.Panel.Controls.Add(Me.indexToolStripExt)
            Me.referencesTabItem.Panel.Controls.Add(Me.tbofAuthoritiesToolStripExt)
            Me.referencesTabItem.Panel.Name = "RibbonPanel4"
            Me.referencesTabItem.Panel.ScrollPosition = 0
            Me.referencesTabItem.Panel.TabIndex = 4
            Me.referencesTabItem.Panel.Text = "References"
            Me.referencesTabItem.Size = New System.Drawing.Size(84, 24)
            Me.referencesTabItem.Text = "References"
            '
            'tbofContentsToolStripExt
            '
            Me.tbofContentsToolStripExt.CollapsedDropDownButtonText = "Contents"
            Me.tbofContentsToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.tbofContentsToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.tbofContentsToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.tbofContentsToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.tbofContentsToolStripExt.Image = CType(resources.GetObject("tbofContentsToolStripExt.Image"), System.Drawing.Image)
            Me.tbofContentsToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem25})
            Me.tbofContentsToolStripExt.Location = New System.Drawing.Point(0, 1)
            Me.tbofContentsToolStripExt.Name = "tbofContentsToolStripExt"
            Me.tbofContentsToolStripExt.ShowLauncher = False
            Me.tbofContentsToolStripExt.Size = New System.Drawing.Size(133, 0)
            Me.tbofContentsToolStripExt.TabIndex = 0
            Me.tbofContentsToolStripExt.Text = "Table of Contents"
            '
            'toolStripPanelItem25
            '
            Me.toolStripPanelItem25.CausesValidation = False
            Me.toolStripPanelItem25.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem25.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tablefcontToolStripDropDownBtn, Me.addtxtToolStripDropDownBtn, Me.updateTableToolStripBtn})
            Me.toolStripPanelItem25.Name = "toolStripPanelItem25"
            Me.toolStripPanelItem25.Size = New System.Drawing.Size(126, 0)
            Me.toolStripPanelItem25.Text = "Table of Contents"
            Me.toolStripPanelItem25.Transparent = True
            '
            'tablefcontToolStripDropDownBtn
            '
            Me.tablefcontToolStripDropDownBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.insertTableOfContentsToolStripMenuItem, Me.removeTableOfContentsToolStripMenuItem, Me.toolStripMenuItem13})
            Me.tablefcontToolStripDropDownBtn.Image = CType(resources.GetObject("tablefcontToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.tablefcontToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tablefcontToolStripDropDownBtn.Name = "tablefcontToolStripDropDownBtn"
            Me.tablefcontToolStripDropDownBtn.Size = New System.Drawing.Size(122, 20)
            Me.tablefcontToolStripDropDownBtn.Text = "Table of Contents"
            ToolTipInfo122.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo122.Body.Hidden = True
            ToolTipInfo122.Footer.Hidden = True
            ToolTipInfo122.Header.Text = "Table of Contents"
            ToolTipInfo122.Separator = False
            Me.superToolTip1.SetToolTip(Me.tablefcontToolStripDropDownBtn, ToolTipInfo122)
            '
            'insertTableOfContentsToolStripMenuItem
            '
            Me.insertTableOfContentsToolStripMenuItem.Name = "insertTableOfContentsToolStripMenuItem"
            Me.insertTableOfContentsToolStripMenuItem.Size = New System.Drawing.Size(305, 22)
            Me.insertTableOfContentsToolStripMenuItem.Text = "&Insert Table of Contents..."
            '
            'removeTableOfContentsToolStripMenuItem
            '
            Me.removeTableOfContentsToolStripMenuItem.Name = "removeTableOfContentsToolStripMenuItem"
            Me.removeTableOfContentsToolStripMenuItem.Size = New System.Drawing.Size(305, 22)
            Me.removeTableOfContentsToolStripMenuItem.Text = "&Remove Table of Contents"
            '
            'toolStripMenuItem13
            '
            Me.toolStripMenuItem13.Name = "toolStripMenuItem13"
            Me.toolStripMenuItem13.Size = New System.Drawing.Size(305, 22)
            Me.toolStripMenuItem13.Text = "&Save Selection to Table of Contents Gallery..."
            '
            'addtxtToolStripDropDownBtn
            '
            Me.addtxtToolStripDropDownBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.doNotToolStripMenuItem, Me.level1ToolStripMenuItem, Me.level2ToolStripMenuItem, Me.level3ToolStripMenuItem})
            Me.addtxtToolStripDropDownBtn.Image = CType(resources.GetObject("addtxtToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.addtxtToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.addtxtToolStripDropDownBtn.Name = "addtxtToolStripDropDownBtn"
            Me.addtxtToolStripDropDownBtn.Size = New System.Drawing.Size(80, 20)
            Me.addtxtToolStripDropDownBtn.Text = "Add Text"
            ToolTipInfo123.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo123.Body.Hidden = True
            ToolTipInfo123.Footer.Hidden = True
            ToolTipInfo123.Header.Text = "Add Text"
            ToolTipInfo123.Separator = False
            Me.superToolTip1.SetToolTip(Me.addtxtToolStripDropDownBtn, ToolTipInfo123)
            '
            'doNotToolStripMenuItem
            '
            Me.doNotToolStripMenuItem.Checked = True
            Me.doNotToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.doNotToolStripMenuItem.Name = "doNotToolStripMenuItem"
            Me.doNotToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
            Me.doNotToolStripMenuItem.Text = "Do Not Show in Table of Contents"
            '
            'level1ToolStripMenuItem
            '
            Me.level1ToolStripMenuItem.Name = "level1ToolStripMenuItem"
            Me.level1ToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
            Me.level1ToolStripMenuItem.Text = "Level 1"
            '
            'level2ToolStripMenuItem
            '
            Me.level2ToolStripMenuItem.Name = "level2ToolStripMenuItem"
            Me.level2ToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
            Me.level2ToolStripMenuItem.Text = "Level 2"
            '
            'level3ToolStripMenuItem
            '
            Me.level3ToolStripMenuItem.Name = "level3ToolStripMenuItem"
            Me.level3ToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
            Me.level3ToolStripMenuItem.Text = "Level 3"
            '
            'updateTableToolStripBtn
            '
            Me.updateTableToolStripBtn.Image = CType(resources.GetObject("updateTableToolStripBtn.Image"), System.Drawing.Image)
            Me.updateTableToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.updateTableToolStripBtn.Name = "updateTableToolStripBtn"
            Me.updateTableToolStripBtn.Size = New System.Drawing.Size(91, 20)
            Me.updateTableToolStripBtn.Text = "Update Table"
            ToolTipInfo124.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo124.Body.Hidden = True
            ToolTipInfo124.Footer.Hidden = True
            ToolTipInfo124.Header.Text = "Update Table"
            ToolTipInfo124.Separator = False
            Me.superToolTip1.SetToolTip(Me.updateTableToolStripBtn, ToolTipInfo124)
            '
            'footNotesToolStripExt
            '
            Me.footNotesToolStripExt.CollapsedDropDownButtonText = "FootNotes"
            Me.footNotesToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.footNotesToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.footNotesToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.footNotesToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.footNotesToolStripExt.Image = CType(resources.GetObject("footNotesToolStripExt.Image"), System.Drawing.Image)
            Me.footNotesToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.inftnoteToolStripBtn, Me.toolStripPanelItem26})
            Me.footNotesToolStripExt.Location = New System.Drawing.Point(133, 1)
            Me.footNotesToolStripExt.Name = "footNotesToolStripExt"
            Me.footNotesToolStripExt.Size = New System.Drawing.Size(175, 0)
            Me.footNotesToolStripExt.TabIndex = 1
            Me.footNotesToolStripExt.Text = "Foot notes"
            ToolTipInfo129.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo129.Header.Text = "Foot notes"
            Me.superToolTip1.SetToolTip(Me.footNotesToolStripExt, ToolTipInfo129)
            '
            'inftnoteToolStripBtn
            '
            Me.inftnoteToolStripBtn.Image = CType(resources.GetObject("inftnoteToolStripBtn.Image"), System.Drawing.Image)
            Me.inftnoteToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.inftnoteToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.inftnoteToolStripBtn.Name = "inftnoteToolStripBtn"
            Me.inftnoteToolStripBtn.Size = New System.Drawing.Size(55, 0)
            Me.inftnoteToolStripBtn.Text = "Insert" & Global.Microsoft.VisualBasic.ChrW(10) & "Footnote"
            Me.inftnoteToolStripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo125.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo125.Body.Hidden = True
            ToolTipInfo125.Footer.Hidden = True
            ToolTipInfo125.Header.Text = "Insert Footnote"
            ToolTipInfo125.Separator = False
            Me.superToolTip1.SetToolTip(Me.inftnoteToolStripBtn, ToolTipInfo125)
            '
            'toolStripPanelItem26
            '
            Me.toolStripPanelItem26.CausesValidation = False
            Me.toolStripPanelItem26.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem26.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.inendnoteToolStripBtn, Me.nxtftnoteToolStripSplitBtn, Me.shNotesToolStripBtn})
            Me.toolStripPanelItem26.Name = "toolStripPanelItem26"
            Me.toolStripPanelItem26.Size = New System.Drawing.Size(113, 0)
            Me.toolStripPanelItem26.Text = "toolStripPanelItem26"
            Me.toolStripPanelItem26.Transparent = True
            '
            'inendnoteToolStripBtn
            '
            Me.inendnoteToolStripBtn.Image = CType(resources.GetObject("inendnoteToolStripBtn.Image"), System.Drawing.Image)
            Me.inendnoteToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.inendnoteToolStripBtn.Name = "inendnoteToolStripBtn"
            Me.inendnoteToolStripBtn.Size = New System.Drawing.Size(99, 20)
            Me.inendnoteToolStripBtn.Text = "Insert Endnote"
            ToolTipInfo126.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo126.Body.Hidden = True
            ToolTipInfo126.Footer.Hidden = True
            ToolTipInfo126.Header.Text = "Insert Endnote"
            ToolTipInfo126.Separator = False
            Me.superToolTip1.SetToolTip(Me.inendnoteToolStripBtn, ToolTipInfo126)
            '
            'nxtftnoteToolStripSplitBtn
            '
            Me.nxtftnoteToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nextFootnoteToolStripMenuItem, Me.previousFootnoteToolStripMenuItem, Me.nextEndnoteToolStripMenuItem, Me.prevToolStripMenuItem})
            Me.nxtftnoteToolStripSplitBtn.Image = CType(resources.GetObject("nxtftnoteToolStripSplitBtn.Image"), System.Drawing.Image)
            Me.nxtftnoteToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.nxtftnoteToolStripSplitBtn.Name = "nxtftnoteToolStripSplitBtn"
            Me.nxtftnoteToolStripSplitBtn.Size = New System.Drawing.Size(109, 20)
            Me.nxtftnoteToolStripSplitBtn.Text = "Next Footnote"
            ToolTipInfo127.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo127.Body.Hidden = True
            ToolTipInfo127.Footer.Hidden = True
            ToolTipInfo127.Header.Text = "Next Footnote"
            ToolTipInfo127.Separator = False
            Me.superToolTip1.SetToolTip(Me.nxtftnoteToolStripSplitBtn, ToolTipInfo127)
            '
            'nextFootnoteToolStripMenuItem
            '
            Me.nextFootnoteToolStripMenuItem.Name = "nextFootnoteToolStripMenuItem"
            Me.nextFootnoteToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
            Me.nextFootnoteToolStripMenuItem.Text = "&Next Footnote"
            '
            'previousFootnoteToolStripMenuItem
            '
            Me.previousFootnoteToolStripMenuItem.Name = "previousFootnoteToolStripMenuItem"
            Me.previousFootnoteToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
            Me.previousFootnoteToolStripMenuItem.Text = "&Previous Footnote"
            '
            'nextEndnoteToolStripMenuItem
            '
            Me.nextEndnoteToolStripMenuItem.Name = "nextEndnoteToolStripMenuItem"
            Me.nextEndnoteToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
            Me.nextEndnoteToolStripMenuItem.Text = "Ne&xt Endnote"
            '
            'prevToolStripMenuItem
            '
            Me.prevToolStripMenuItem.Name = "prevToolStripMenuItem"
            Me.prevToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
            Me.prevToolStripMenuItem.Text = "Pre&vious Endnote"
            '
            'shNotesToolStripBtn
            '
            Me.shNotesToolStripBtn.Image = CType(resources.GetObject("shNotesToolStripBtn.Image"), System.Drawing.Image)
            Me.shNotesToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.shNotesToolStripBtn.Name = "shNotesToolStripBtn"
            Me.shNotesToolStripBtn.Size = New System.Drawing.Size(83, 20)
            Me.shNotesToolStripBtn.Text = "Show notes"
            ToolTipInfo128.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo128.Body.Hidden = True
            ToolTipInfo128.Footer.Hidden = True
            ToolTipInfo128.Header.Text = "Show notes"
            ToolTipInfo128.Separator = False
            Me.superToolTip1.SetToolTip(Me.shNotesToolStripBtn, ToolTipInfo128)
            '
            'citationsToolStripExt
            '
            Me.citationsToolStripExt.CollapsedDropDownButtonText = "Citations"
            Me.citationsToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.citationsToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.citationsToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.citationsToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.citationsToolStripExt.Image = CType(resources.GetObject("citationsToolStripExt.Image"), System.Drawing.Image)
            Me.citationsToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.inCaptionToolStripDropDownBtn, Me.toolStripPanelItem27})
            Me.citationsToolStripExt.Location = New System.Drawing.Point(308, 1)
            Me.citationsToolStripExt.Name = "citationsToolStripExt"
            Me.citationsToolStripExt.ShowLauncher = False
            Me.citationsToolStripExt.Size = New System.Drawing.Size(220, 0)
            Me.citationsToolStripExt.TabIndex = 2
            Me.citationsToolStripExt.Text = "Citations && Bibliography"
            '
            'inCaptionToolStripDropDownBtn
            '
            Me.inCaptionToolStripDropDownBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addNewSourceToolStripMenuItem, Me.addNewPlaceholderToolStripMenuItem, Me.searchLibrariesToolStripMenuItem})
            Me.inCaptionToolStripDropDownBtn.Image = CType(resources.GetObject("inCaptionToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.inCaptionToolStripDropDownBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.inCaptionToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.inCaptionToolStripDropDownBtn.Name = "inCaptionToolStripDropDownBtn"
            Me.inCaptionToolStripDropDownBtn.Size = New System.Drawing.Size(57, 0)
            Me.inCaptionToolStripDropDownBtn.Text = "Insert" & Global.Microsoft.VisualBasic.ChrW(10) & "Citation"
            Me.inCaptionToolStripDropDownBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo130.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo130.Header.Text = "Insert Citation"
            Me.superToolTip1.SetToolTip(Me.inCaptionToolStripDropDownBtn, ToolTipInfo130)
            '
            'addNewSourceToolStripMenuItem
            '
            Me.addNewSourceToolStripMenuItem.Name = "addNewSourceToolStripMenuItem"
            Me.addNewSourceToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
            Me.addNewSourceToolStripMenuItem.Text = "Add New &Source..."
            '
            'addNewPlaceholderToolStripMenuItem
            '
            Me.addNewPlaceholderToolStripMenuItem.Name = "addNewPlaceholderToolStripMenuItem"
            Me.addNewPlaceholderToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
            Me.addNewPlaceholderToolStripMenuItem.Text = "Add New &Placeholder..."
            '
            'searchLibrariesToolStripMenuItem
            '
            Me.searchLibrariesToolStripMenuItem.Name = "searchLibrariesToolStripMenuItem"
            Me.searchLibrariesToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
            Me.searchLibrariesToolStripMenuItem.Text = "Search &Libraries..."
            '
            'toolStripPanelItem27
            '
            Me.toolStripPanelItem27.CausesValidation = False
            Me.toolStripPanelItem27.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem27.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mgeSourcesToolStripBtn, Me.toolStripPanelItem28, Me.bibliographyToolStripDropDownBtn})
            Me.toolStripPanelItem27.Name = "toolStripPanelItem27"
            Me.toolStripPanelItem27.Size = New System.Drawing.Size(138, 0)
            Me.toolStripPanelItem27.Text = "toolStripPanelItem27"
            Me.toolStripPanelItem27.Transparent = True
            '
            'mgeSourcesToolStripBtn
            '
            Me.mgeSourcesToolStripBtn.Image = CType(resources.GetObject("mgeSourcesToolStripBtn.Image"), System.Drawing.Image)
            Me.mgeSourcesToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.mgeSourcesToolStripBtn.Name = "mgeSourcesToolStripBtn"
            Me.mgeSourcesToolStripBtn.Size = New System.Drawing.Size(106, 20)
            Me.mgeSourcesToolStripBtn.Text = "Manage Sources"
            ToolTipInfo131.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo131.Body.Hidden = True
            ToolTipInfo131.Footer.Hidden = True
            ToolTipInfo131.Header.Text = "Manage Sources"
            ToolTipInfo131.Separator = False
            Me.superToolTip1.SetToolTip(Me.mgeSourcesToolStripBtn, ToolTipInfo131)
            '
            'toolStripPanelItem28
            '
            Me.toolStripPanelItem28.CausesValidation = False
            Me.toolStripPanelItem28.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem28.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.styleToolStripLabel, Me.ToolStripStyleComboBox})
            Me.toolStripPanelItem28.Name = "toolStripPanelItem28"
            Me.toolStripPanelItem28.RowCount = 1
            Me.toolStripPanelItem28.Size = New System.Drawing.Size(132, 25)
            Me.toolStripPanelItem28.Text = "toolStripPanelItem28"
            Me.toolStripPanelItem28.Transparent = True
            '
            'styleToolStripLabel
            '
            Me.styleToolStripLabel.Image = CType(resources.GetObject("styleToolStripLabel.Image"), System.Drawing.Image)
            Me.styleToolStripLabel.Name = "styleToolStripLabel"
            Me.styleToolStripLabel.Size = New System.Drawing.Size(51, 16)
            Me.styleToolStripLabel.Text = "Style:"
            ToolTipInfo132.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo132.Header.Text = "Styles"
            Me.superToolTip1.SetToolTip(Me.styleToolStripLabel, ToolTipInfo132)
            '
            'ToolStripStyleComboBox
            '
            Me.ToolStripStyleComboBox.Name = "ToolStripStyleComboBox"
            Me.ToolStripStyleComboBox.Size = New System.Drawing.Size(75, 21)
            Me.ToolStripStyleComboBox.Text = "No default style"
            '
            'bibliographyToolStripDropDownBtn
            '
            Me.bibliographyToolStripDropDownBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.insertBibliographyToolStripMenuItem, Me.saveSelectionToBibliographyGalleryToolStripMenuItem, Me.saveAsNewBibliographyToolStripMenuItem})
            Me.bibliographyToolStripDropDownBtn.Image = CType(resources.GetObject("bibliographyToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.bibliographyToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bibliographyToolStripDropDownBtn.Name = "bibliographyToolStripDropDownBtn"
            Me.bibliographyToolStripDropDownBtn.Size = New System.Drawing.Size(94, 20)
            Me.bibliographyToolStripDropDownBtn.Text = "Bibliography"
            ToolTipInfo133.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo133.Body.Hidden = True
            ToolTipInfo133.Footer.Hidden = True
            ToolTipInfo133.Header.Text = "Bibliography"
            ToolTipInfo133.Separator = False
            Me.superToolTip1.SetToolTip(Me.bibliographyToolStripDropDownBtn, ToolTipInfo133)
            '
            'insertBibliographyToolStripMenuItem
            '
            Me.insertBibliographyToolStripMenuItem.Name = "insertBibliographyToolStripMenuItem"
            Me.insertBibliographyToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
            Me.insertBibliographyToolStripMenuItem.Text = "Insert &Bibliography"
            '
            'saveSelectionToBibliographyGalleryToolStripMenuItem
            '
            Me.saveSelectionToBibliographyGalleryToolStripMenuItem.Enabled = False
            Me.saveSelectionToBibliographyGalleryToolStripMenuItem.Name = "saveSelectionToBibliographyGalleryToolStripMenuItem"
            Me.saveSelectionToBibliographyGalleryToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
            Me.saveSelectionToBibliographyGalleryToolStripMenuItem.Text = "&Save Selection to Bibliography Gallery..."
            '
            'saveAsNewBibliographyToolStripMenuItem
            '
            Me.saveAsNewBibliographyToolStripMenuItem.Name = "saveAsNewBibliographyToolStripMenuItem"
            Me.saveAsNewBibliographyToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
            Me.saveAsNewBibliographyToolStripMenuItem.Text = "Save as &New Bibliography..."
            '
            'captionsToolStripExt
            '
            Me.captionsToolStripExt.CollapsedDropDownButtonText = "Captions"
            Me.captionsToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.captionsToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.captionsToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.captionsToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.captionsToolStripExt.Image = CType(resources.GetObject("captionsToolStripExt.Image"), System.Drawing.Image)
            Me.captionsToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.inCaptionToolStripBtn, Me.toolStripPanelItem29})
            Me.captionsToolStripExt.Location = New System.Drawing.Point(528, 1)
            Me.captionsToolStripExt.Name = "captionsToolStripExt"
            Me.captionsToolStripExt.ShowLauncher = False
            Me.captionsToolStripExt.Size = New System.Drawing.Size(195, 0)
            Me.captionsToolStripExt.TabIndex = 3
            Me.captionsToolStripExt.Text = "Captions"
            '
            'inCaptionToolStripBtn
            '
            Me.inCaptionToolStripBtn.Image = CType(resources.GetObject("inCaptionToolStripBtn.Image"), System.Drawing.Image)
            Me.inCaptionToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.inCaptionToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.inCaptionToolStripBtn.Name = "inCaptionToolStripBtn"
            Me.inCaptionToolStripBtn.Size = New System.Drawing.Size(48, 0)
            Me.inCaptionToolStripBtn.Text = "Insert" & Global.Microsoft.VisualBasic.ChrW(10) & "Caption"
            Me.inCaptionToolStripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo134.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo134.Body.Hidden = True
            ToolTipInfo134.Footer.Hidden = True
            ToolTipInfo134.Header.Text = "Insert Caption"
            ToolTipInfo134.Separator = False
            Me.superToolTip1.SetToolTip(Me.inCaptionToolStripBtn, ToolTipInfo134)
            '
            'toolStripPanelItem29
            '
            Me.toolStripPanelItem29.CausesValidation = False
            Me.toolStripPanelItem29.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem29.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.inTbofFiguresToolStripBtn, Me.upTableToolStripBtn, Me.crrefToolStripBtn})
            Me.toolStripPanelItem29.Name = "toolStripPanelItem29"
            Me.toolStripPanelItem29.Size = New System.Drawing.Size(140, 0)
            Me.toolStripPanelItem29.Text = "toolStripPanelItem29"
            Me.toolStripPanelItem29.Transparent = True
            '
            'inTbofFiguresToolStripBtn
            '
            Me.inTbofFiguresToolStripBtn.Image = CType(resources.GetObject("inTbofFiguresToolStripBtn.Image"), System.Drawing.Image)
            Me.inTbofFiguresToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.inTbofFiguresToolStripBtn.Name = "inTbofFiguresToolStripBtn"
            Me.inTbofFiguresToolStripBtn.Size = New System.Drawing.Size(136, 20)
            Me.inTbofFiguresToolStripBtn.Text = "Insert Table of Figures"
            ToolTipInfo135.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo135.Body.Hidden = True
            ToolTipInfo135.Footer.Hidden = True
            ToolTipInfo135.Header.Text = "Insert Table of Figures"
            ToolTipInfo135.Separator = False
            Me.superToolTip1.SetToolTip(Me.inTbofFiguresToolStripBtn, ToolTipInfo135)
            '
            'upTableToolStripBtn
            '
            Me.upTableToolStripBtn.Image = CType(resources.GetObject("upTableToolStripBtn.Image"), System.Drawing.Image)
            Me.upTableToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.upTableToolStripBtn.Name = "upTableToolStripBtn"
            Me.upTableToolStripBtn.Size = New System.Drawing.Size(91, 20)
            Me.upTableToolStripBtn.Text = "Update Table"
            ToolTipInfo136.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo136.Body.Hidden = True
            ToolTipInfo136.Footer.Hidden = True
            ToolTipInfo136.Header.Text = "Update Table"
            ToolTipInfo136.Separator = False
            Me.superToolTip1.SetToolTip(Me.upTableToolStripBtn, ToolTipInfo136)
            '
            'crrefToolStripBtn
            '
            Me.crrefToolStripBtn.Image = CType(resources.GetObject("crrefToolStripBtn.Image"), System.Drawing.Image)
            Me.crrefToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.crrefToolStripBtn.Name = "crrefToolStripBtn"
            Me.crrefToolStripBtn.Size = New System.Drawing.Size(105, 20)
            Me.crrefToolStripBtn.Text = "Cross-reference"
            ToolTipInfo137.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo137.Body.Hidden = True
            ToolTipInfo137.Footer.Hidden = True
            ToolTipInfo137.Header.Text = "Cross-reference"
            ToolTipInfo137.Separator = False
            Me.superToolTip1.SetToolTip(Me.crrefToolStripBtn, ToolTipInfo137)
            '
            'indexToolStripExt
            '
            Me.indexToolStripExt.CollapsedDropDownButtonText = "Indexing"
            Me.indexToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.indexToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.indexToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.indexToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.indexToolStripExt.Image = CType(resources.GetObject("indexToolStripExt.Image"), System.Drawing.Image)
            Me.indexToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem30})
            Me.indexToolStripExt.Location = New System.Drawing.Point(723, 1)
            Me.indexToolStripExt.Name = "indexToolStripExt"
            Me.indexToolStripExt.ShowLauncher = False
            Me.indexToolStripExt.Size = New System.Drawing.Size(108, 0)
            Me.indexToolStripExt.TabIndex = 4
            Me.indexToolStripExt.Text = "Index"
            '
            'toolStripPanelItem30
            '
            Me.toolStripPanelItem30.CausesValidation = False
            Me.toolStripPanelItem30.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem30.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.markEntryToolStripBtn, Me.inIndexToolStripBtn, Me.uIndexToolStripBtn})
            Me.toolStripPanelItem30.Name = "toolStripPanelItem30"
            Me.toolStripPanelItem30.Size = New System.Drawing.Size(97, 0)
            Me.toolStripPanelItem30.Text = "toolStripPanelItem30"
            Me.toolStripPanelItem30.Transparent = True
            '
            'markEntryToolStripBtn
            '
            Me.markEntryToolStripBtn.Image = CType(resources.GetObject("markEntryToolStripBtn.Image"), System.Drawing.Image)
            Me.markEntryToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.markEntryToolStripBtn.Name = "markEntryToolStripBtn"
            Me.markEntryToolStripBtn.Size = New System.Drawing.Size(79, 20)
            Me.markEntryToolStripBtn.Text = "Mark Entry"
            ToolTipInfo138.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo138.Body.Hidden = True
            ToolTipInfo138.Footer.Hidden = True
            ToolTipInfo138.Header.Text = "Mark Entry"
            ToolTipInfo138.Separator = False
            Me.superToolTip1.SetToolTip(Me.markEntryToolStripBtn, ToolTipInfo138)
            '
            'inIndexToolStripBtn
            '
            Me.inIndexToolStripBtn.Image = CType(resources.GetObject("inIndexToolStripBtn.Image"), System.Drawing.Image)
            Me.inIndexToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.inIndexToolStripBtn.Name = "inIndexToolStripBtn"
            Me.inIndexToolStripBtn.Size = New System.Drawing.Size(87, 20)
            Me.inIndexToolStripBtn.Text = "Insert Index"
            ToolTipInfo139.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo139.Body.Hidden = True
            ToolTipInfo139.Footer.Hidden = True
            ToolTipInfo139.Header.Text = "Insert Index"
            ToolTipInfo139.Separator = False
            Me.superToolTip1.SetToolTip(Me.inIndexToolStripBtn, ToolTipInfo139)
            '
            'uIndexToolStripBtn
            '
            Me.uIndexToolStripBtn.Image = CType(resources.GetObject("uIndexToolStripBtn.Image"), System.Drawing.Image)
            Me.uIndexToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.uIndexToolStripBtn.Name = "uIndexToolStripBtn"
            Me.uIndexToolStripBtn.Size = New System.Drawing.Size(93, 20)
            Me.uIndexToolStripBtn.Text = "Update Index"
            ToolTipInfo140.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo140.Body.Hidden = True
            ToolTipInfo140.Footer.Hidden = True
            ToolTipInfo140.Header.Text = "Update Index"
            ToolTipInfo140.Separator = False
            Me.superToolTip1.SetToolTip(Me.uIndexToolStripBtn, ToolTipInfo140)
            '
            'tbofAuthoritiesToolStripExt
            '
            Me.tbofAuthoritiesToolStripExt.CollapsedDropDownButtonText = "Table of Authorities"
            Me.tbofAuthoritiesToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.tbofAuthoritiesToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.tbofAuthoritiesToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.tbofAuthoritiesToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.tbofAuthoritiesToolStripExt.Image = CType(resources.GetObject("tbofAuthoritiesToolStripExt.Image"), System.Drawing.Image)
            Me.tbofAuthoritiesToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem31})
            Me.tbofAuthoritiesToolStripExt.Location = New System.Drawing.Point(831, 1)
            Me.tbofAuthoritiesToolStripExt.Name = "tbofAuthoritiesToolStripExt"
            Me.tbofAuthoritiesToolStripExt.ShowLauncher = False
            Me.tbofAuthoritiesToolStripExt.Size = New System.Drawing.Size(164, 0)
            Me.tbofAuthoritiesToolStripExt.TabIndex = 5
            Me.tbofAuthoritiesToolStripExt.Text = "Table of Authorities"
            '
            'toolStripPanelItem31
            '
            Me.toolStripPanelItem31.CausesValidation = False
            Me.toolStripPanelItem31.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem31.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.markCitationToolStripBtn, Me.inTbofAuthoritiesToolStripBtn, Me.uTableToolStripBtn})
            Me.toolStripPanelItem31.Name = "toolStripPanelItem31"
            Me.toolStripPanelItem31.Size = New System.Drawing.Size(157, 0)
            Me.toolStripPanelItem31.Text = "toolStripPanelItem31"
            Me.toolStripPanelItem31.Transparent = True
            '
            'markCitationToolStripBtn
            '
            Me.markCitationToolStripBtn.Image = CType(resources.GetObject("markCitationToolStripBtn.Image"), System.Drawing.Image)
            Me.markCitationToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.markCitationToolStripBtn.Name = "markCitationToolStripBtn"
            Me.markCitationToolStripBtn.Size = New System.Drawing.Size(90, 20)
            Me.markCitationToolStripBtn.Text = "Mark Citation"
            ToolTipInfo141.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo141.Body.Hidden = True
            ToolTipInfo141.Footer.Hidden = True
            ToolTipInfo141.Header.Text = "Mark Citation"
            ToolTipInfo141.Separator = False
            Me.superToolTip1.SetToolTip(Me.markCitationToolStripBtn, ToolTipInfo141)
            '
            'inTbofAuthoritiesToolStripBtn
            '
            Me.inTbofAuthoritiesToolStripBtn.Image = CType(resources.GetObject("inTbofAuthoritiesToolStripBtn.Image"), System.Drawing.Image)
            Me.inTbofAuthoritiesToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.inTbofAuthoritiesToolStripBtn.Name = "inTbofAuthoritiesToolStripBtn"
            Me.inTbofAuthoritiesToolStripBtn.Size = New System.Drawing.Size(153, 20)
            Me.inTbofAuthoritiesToolStripBtn.Text = "Insert Table of Authorities"
            ToolTipInfo142.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo142.Body.Hidden = True
            ToolTipInfo142.Footer.Hidden = True
            ToolTipInfo142.Header.Text = "Insert Table of Authorities"
            ToolTipInfo142.Separator = False
            Me.superToolTip1.SetToolTip(Me.inTbofAuthoritiesToolStripBtn, ToolTipInfo142)
            '
            'uTableToolStripBtn
            '
            Me.uTableToolStripBtn.Image = CType(resources.GetObject("uTableToolStripBtn.Image"), System.Drawing.Image)
            Me.uTableToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.uTableToolStripBtn.Name = "uTableToolStripBtn"
            Me.uTableToolStripBtn.Size = New System.Drawing.Size(91, 20)
            Me.uTableToolStripBtn.Text = "Update Table"
            ToolTipInfo143.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo143.Body.Hidden = True
            ToolTipInfo143.Footer.Hidden = True
            ToolTipInfo143.Header.Text = "Update Table"
            ToolTipInfo143.Separator = False
            Me.superToolTip1.SetToolTip(Me.uTableToolStripBtn, ToolTipInfo143)
            '
            'mailingsTabItem
            '
            Me.superAccelerator.SetAccelerator(Me.mailingsTabItem, "M")
            Me.mailingsTabItem.ForeColor = System.Drawing.Color.MidnightBlue
            Me.mailingsTabItem.Name = "mailingsTabItem"
            Me.mailingsTabItem.Padding = New System.Windows.Forms.Padding(15, 2, 3, 5)
            '
            'ribbonControlAdv1.RibbonPanel5
            '
            Me.mailingsTabItem.Panel.Controls.Add(Me.createToolStripExt)
            Me.mailingsTabItem.Panel.Controls.Add(Me.stMailMergeToolStripExt)
            Me.mailingsTabItem.Panel.Controls.Add(Me.insertFieldsToolStripExt)
            Me.mailingsTabItem.Panel.Controls.Add(Me.previewResultsToolStripExt)
            Me.mailingsTabItem.Panel.Controls.Add(Me.finishToolStripExt)
            Me.mailingsTabItem.Panel.Name = "RibbonPanel5"
            Me.mailingsTabItem.Panel.ScrollPosition = 0
            Me.mailingsTabItem.Panel.TabIndex = 5
            Me.mailingsTabItem.Panel.Text = "Mailings"
            Me.mailingsTabItem.Size = New System.Drawing.Size(66, 24)
            Me.mailingsTabItem.Text = "Mailings"
            '
            'createToolStripExt
            '
            Me.createToolStripExt.CollapsedDropDownButtonText = "Create"
            Me.createToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.createToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.createToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.createToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.createToolStripExt.Image = CType(resources.GetObject("createToolStripExt.Image"), System.Drawing.Image)
            Me.createToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.envelopeToolStripBtn, Me.labelsToolStripBtn})
            Me.createToolStripExt.Location = New System.Drawing.Point(0, 1)
            Me.createToolStripExt.Name = "createToolStripExt"
            Me.createToolStripExt.ShowLauncher = False
            Me.createToolStripExt.Size = New System.Drawing.Size(112, 0)
            Me.createToolStripExt.TabIndex = 0
            Me.createToolStripExt.Text = "Create"
            '
            'envelopeToolStripBtn
            '
            Me.envelopeToolStripBtn.Image = CType(resources.GetObject("envelopeToolStripBtn.Image"), System.Drawing.Image)
            Me.envelopeToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.envelopeToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.envelopeToolStripBtn.Name = "envelopeToolStripBtn"
            Me.envelopeToolStripBtn.Size = New System.Drawing.Size(60, 0)
            Me.envelopeToolStripBtn.Text = "Envelopes"
            Me.envelopeToolStripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo144.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo144.Body.Hidden = True
            ToolTipInfo144.Footer.Hidden = True
            ToolTipInfo144.Header.Text = "Envelopes"
            ToolTipInfo144.Separator = False
            Me.superToolTip1.SetToolTip(Me.envelopeToolStripBtn, ToolTipInfo144)
            '
            'labelsToolStripBtn
            '
            Me.labelsToolStripBtn.Image = CType(resources.GetObject("labelsToolStripBtn.Image"), System.Drawing.Image)
            Me.labelsToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.labelsToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.labelsToolStripBtn.Name = "labelsToolStripBtn"
            Me.labelsToolStripBtn.Size = New System.Drawing.Size(41, 0)
            Me.labelsToolStripBtn.Text = "Labels"
            Me.labelsToolStripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo145.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo145.Body.Hidden = True
            ToolTipInfo145.Footer.Hidden = True
            ToolTipInfo145.Header.Text = "Labels"
            ToolTipInfo145.Separator = False
            Me.superToolTip1.SetToolTip(Me.labelsToolStripBtn, ToolTipInfo145)
            '
            'stMailMergeToolStripExt
            '
            Me.stMailMergeToolStripExt.CollapsedDropDownButtonText = "Mail Merge"
            Me.stMailMergeToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.stMailMergeToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.stMailMergeToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.stMailMergeToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.stMailMergeToolStripExt.Image = CType(resources.GetObject("stMailMergeToolStripExt.Image"), System.Drawing.Image)
            Me.stMailMergeToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stMailMergeToolStripDropDownBtn, Me.sltRecipientsToolStripDropDownBtn, Me.editRecepientsToolStripBtn})
            Me.stMailMergeToolStripExt.Location = New System.Drawing.Point(112, 1)
            Me.stMailMergeToolStripExt.Name = "stMailMergeToolStripExt"
            Me.stMailMergeToolStripExt.ShowLauncher = False
            Me.stMailMergeToolStripExt.Size = New System.Drawing.Size(221, 0)
            Me.stMailMergeToolStripExt.TabIndex = 1
            Me.stMailMergeToolStripExt.Text = "Start Mail Merge"
            '
            'stMailMergeToolStripDropDownBtn
            '
            Me.stMailMergeToolStripDropDownBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lettersToolStripMenuItem, Me.emailMessagesToolStripMenuItem, Me.envelopesToolStripMenuItem, Me.lablesToolStripMenuItem, Me.directoryToolStripMenuItem, Me.toolStripSeparator20, Me.normalWordDocumentToolStripMenuItem, Me.toolStripSeparator21, Me.stepByStepMailMergeWizardToolStripMenuItem})
            Me.stMailMergeToolStripDropDownBtn.Image = CType(resources.GetObject("stMailMergeToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.stMailMergeToolStripDropDownBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.stMailMergeToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.stMailMergeToolStripDropDownBtn.Name = "stMailMergeToolStripDropDownBtn"
            Me.stMailMergeToolStripDropDownBtn.Size = New System.Drawing.Size(71, 0)
            Me.stMailMergeToolStripDropDownBtn.Text = "Start" & Global.Microsoft.VisualBasic.ChrW(10) & "Mail Merge"
            Me.stMailMergeToolStripDropDownBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo146.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo146.Body.Hidden = True
            ToolTipInfo146.Footer.Hidden = True
            ToolTipInfo146.Header.Text = "Start Mail Merge"
            ToolTipInfo146.Separator = False
            Me.superToolTip1.SetToolTip(Me.stMailMergeToolStripDropDownBtn, ToolTipInfo146)
            '
            'lettersToolStripMenuItem
            '
            Me.lettersToolStripMenuItem.Name = "lettersToolStripMenuItem"
            Me.lettersToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
            Me.lettersToolStripMenuItem.Text = "&Letters"
            '
            'emailMessagesToolStripMenuItem
            '
            Me.emailMessagesToolStripMenuItem.Name = "emailMessagesToolStripMenuItem"
            Me.emailMessagesToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
            Me.emailMessagesToolStripMenuItem.Text = "&E-mail messages"
            '
            'envelopesToolStripMenuItem
            '
            Me.envelopesToolStripMenuItem.Name = "envelopesToolStripMenuItem"
            Me.envelopesToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
            Me.envelopesToolStripMenuItem.Text = "En&velopes..."
            '
            'lablesToolStripMenuItem
            '
            Me.lablesToolStripMenuItem.Name = "lablesToolStripMenuItem"
            Me.lablesToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
            Me.lablesToolStripMenuItem.Text = "L&ables..."
            '
            'directoryToolStripMenuItem
            '
            Me.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem"
            Me.directoryToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
            Me.directoryToolStripMenuItem.Text = "&Directory"
            '
            'toolStripSeparator20
            '
            Me.toolStripSeparator20.Name = "toolStripSeparator20"
            Me.toolStripSeparator20.Size = New System.Drawing.Size(246, 6)
            '
            'normalWordDocumentToolStripMenuItem
            '
            Me.normalWordDocumentToolStripMenuItem.Name = "normalWordDocumentToolStripMenuItem"
            Me.normalWordDocumentToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
            Me.normalWordDocumentToolStripMenuItem.Text = "Normal Word Document"
            '
            'toolStripSeparator21
            '
            Me.toolStripSeparator21.Name = "toolStripSeparator21"
            Me.toolStripSeparator21.Size = New System.Drawing.Size(246, 6)
            '
            'stepByStepMailMergeWizardToolStripMenuItem
            '
            Me.stepByStepMailMergeWizardToolStripMenuItem.Name = "stepByStepMailMergeWizardToolStripMenuItem"
            Me.stepByStepMailMergeWizardToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
            Me.stepByStepMailMergeWizardToolStripMenuItem.Text = "Step by Step Mail Merge &Wizard..."
            '
            'sltRecipientsToolStripDropDownBtn
            '
            Me.sltRecipientsToolStripDropDownBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.typeNewListToolStripMenuItem, Me.useExistingListToolStripMenuItem, Me.selectFromOutlookContactsToolStripMenuItem})
            Me.sltRecipientsToolStripDropDownBtn.Image = CType(resources.GetObject("sltRecipientsToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.sltRecipientsToolStripDropDownBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.sltRecipientsToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.sltRecipientsToolStripDropDownBtn.Name = "sltRecipientsToolStripDropDownBtn"
            Me.sltRecipientsToolStripDropDownBtn.Size = New System.Drawing.Size(69, 0)
            Me.sltRecipientsToolStripDropDownBtn.Text = "Select" & Global.Microsoft.VisualBasic.ChrW(10) & "Recipients"
            Me.sltRecipientsToolStripDropDownBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo147.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo147.Body.Hidden = True
            ToolTipInfo147.Footer.Hidden = True
            ToolTipInfo147.Header.Text = "Select Recipients"
            ToolTipInfo147.Separator = False
            Me.superToolTip1.SetToolTip(Me.sltRecipientsToolStripDropDownBtn, ToolTipInfo147)
            '
            'typeNewListToolStripMenuItem
            '
            Me.typeNewListToolStripMenuItem.Name = "typeNewListToolStripMenuItem"
            Me.typeNewListToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
            Me.typeNewListToolStripMenuItem.Text = "Type &New List..."
            '
            'useExistingListToolStripMenuItem
            '
            Me.useExistingListToolStripMenuItem.Name = "useExistingListToolStripMenuItem"
            Me.useExistingListToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
            Me.useExistingListToolStripMenuItem.Text = "Us&e Existing List..."
            '
            'selectFromOutlookContactsToolStripMenuItem
            '
            Me.selectFromOutlookContactsToolStripMenuItem.Name = "selectFromOutlookContactsToolStripMenuItem"
            Me.selectFromOutlookContactsToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
            Me.selectFromOutlookContactsToolStripMenuItem.Text = "Select fr&om Outlook Contacts..."
            '
            'editRecepientsToolStripBtn
            '
            Me.editRecepientsToolStripBtn.Enabled = False
            Me.editRecepientsToolStripBtn.Image = CType(resources.GetObject("editRecepientsToolStripBtn.Image"), System.Drawing.Image)
            Me.editRecepientsToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.editRecepientsToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.editRecepientsToolStripBtn.Name = "editRecepientsToolStripBtn"
            Me.editRecepientsToolStripBtn.Size = New System.Drawing.Size(74, 0)
            Me.editRecepientsToolStripBtn.Text = "Edit" & Global.Microsoft.VisualBasic.ChrW(10) & "Recipient List"
            Me.editRecepientsToolStripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo148.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo148.Body.Hidden = True
            ToolTipInfo148.Footer.Hidden = True
            ToolTipInfo148.Header.Text = "Edit Recipient List"
            ToolTipInfo148.Separator = False
            Me.superToolTip1.SetToolTip(Me.editRecepientsToolStripBtn, ToolTipInfo148)
            '
            'insertFieldsToolStripExt
            '
            Me.insertFieldsToolStripExt.CollapsedDropDownButtonText = "Fields"
            Me.insertFieldsToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.insertFieldsToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.insertFieldsToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.insertFieldsToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.insertFieldsToolStripExt.Image = CType(resources.GetObject("insertFieldsToolStripExt.Image"), System.Drawing.Image)
            Me.insertFieldsToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.highltMergeToolStripBtn, Me.addBlockToolStripBtn, Me.greetingToolStripBtn, Me.inMergeFieldToolStripDropDownBtn, Me.toolStripPanelItem32})
            Me.insertFieldsToolStripExt.Location = New System.Drawing.Point(333, 1)
            Me.insertFieldsToolStripExt.Name = "insertFieldsToolStripExt"
            Me.insertFieldsToolStripExt.ShowLauncher = False
            Me.insertFieldsToolStripExt.Size = New System.Drawing.Size(357, 0)
            Me.insertFieldsToolStripExt.TabIndex = 2
            Me.insertFieldsToolStripExt.Text = "Write && Insert Fields"
            '
            'highltMergeToolStripBtn
            '
            Me.highltMergeToolStripBtn.Enabled = False
            Me.highltMergeToolStripBtn.Image = CType(resources.GetObject("highltMergeToolStripBtn.Image"), System.Drawing.Image)
            Me.highltMergeToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.highltMergeToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.highltMergeToolStripBtn.Name = "highltMergeToolStripBtn"
            Me.highltMergeToolStripBtn.Size = New System.Drawing.Size(71, 0)
            Me.highltMergeToolStripBtn.Text = "Highlight" & Global.Microsoft.VisualBasic.ChrW(10) & "Merge Fields"
            Me.highltMergeToolStripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo149.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo149.Body.Hidden = True
            ToolTipInfo149.Footer.Hidden = True
            ToolTipInfo149.Header.Text = "Highlight Merge Fields"
            ToolTipInfo149.Separator = False
            Me.superToolTip1.SetToolTip(Me.highltMergeToolStripBtn, ToolTipInfo149)
            '
            'addBlockToolStripBtn
            '
            Me.addBlockToolStripBtn.Enabled = False
            Me.addBlockToolStripBtn.Image = CType(resources.GetObject("addBlockToolStripBtn.Image"), System.Drawing.Image)
            Me.addBlockToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.addBlockToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.addBlockToolStripBtn.Name = "addBlockToolStripBtn"
            Me.addBlockToolStripBtn.Size = New System.Drawing.Size(50, 0)
            Me.addBlockToolStripBtn.Text = "Address" & Global.Microsoft.VisualBasic.ChrW(10) & "Block"
            Me.addBlockToolStripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo150.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo150.Body.Hidden = True
            ToolTipInfo150.Footer.Hidden = True
            ToolTipInfo150.Header.Text = "Address Block"
            ToolTipInfo150.Separator = False
            Me.superToolTip1.SetToolTip(Me.addBlockToolStripBtn, ToolTipInfo150)
            '
            'greetingToolStripBtn
            '
            Me.greetingToolStripBtn.Enabled = False
            Me.greetingToolStripBtn.Image = CType(resources.GetObject("greetingToolStripBtn.Image"), System.Drawing.Image)
            Me.greetingToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.greetingToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.greetingToolStripBtn.Name = "greetingToolStripBtn"
            Me.greetingToolStripBtn.Size = New System.Drawing.Size(52, 0)
            Me.greetingToolStripBtn.Text = "Greeting" & Global.Microsoft.VisualBasic.ChrW(10) & "Line"
            Me.greetingToolStripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo151.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo151.Body.Hidden = True
            ToolTipInfo151.Footer.Hidden = True
            ToolTipInfo151.Header.Text = "Greeting Line"
            ToolTipInfo151.Separator = False
            Me.superToolTip1.SetToolTip(Me.greetingToolStripBtn, ToolTipInfo151)
            '
            'inMergeFieldToolStripDropDownBtn
            '
            Me.inMergeFieldToolStripDropDownBtn.Enabled = False
            Me.inMergeFieldToolStripDropDownBtn.Image = CType(resources.GetObject("inMergeFieldToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.inMergeFieldToolStripDropDownBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.inMergeFieldToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.inMergeFieldToolStripDropDownBtn.Name = "inMergeFieldToolStripDropDownBtn"
            Me.inMergeFieldToolStripDropDownBtn.Size = New System.Drawing.Size(75, 0)
            Me.inMergeFieldToolStripDropDownBtn.Text = "Insert" & Global.Microsoft.VisualBasic.ChrW(10) & "Merge Field"
            Me.inMergeFieldToolStripDropDownBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo152.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo152.Body.Hidden = True
            ToolTipInfo152.Footer.Hidden = True
            ToolTipInfo152.Header.Text = "Insert Merge Field"
            ToolTipInfo152.Separator = False
            Me.superToolTip1.SetToolTip(Me.inMergeFieldToolStripDropDownBtn, ToolTipInfo152)
            '
            'toolStripPanelItem32
            '
            Me.toolStripPanelItem32.CausesValidation = False
            Me.toolStripPanelItem32.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem32.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rulesToolStripDropDownBtn, Me.matchFieldsToolStripBtn, Me.upLablesToolStripBtn})
            Me.toolStripPanelItem32.Name = "toolStripPanelItem32"
            Me.toolStripPanelItem32.Size = New System.Drawing.Size(99, 0)
            Me.toolStripPanelItem32.Text = "toolStripPanelItem32"
            Me.toolStripPanelItem32.Transparent = True
            '
            'rulesToolStripDropDownBtn
            '
            Me.rulesToolStripDropDownBtn.Enabled = False
            Me.rulesToolStripDropDownBtn.Image = CType(resources.GetObject("rulesToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.rulesToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.rulesToolStripDropDownBtn.Name = "rulesToolStripDropDownBtn"
            Me.rulesToolStripDropDownBtn.Size = New System.Drawing.Size(62, 20)
            Me.rulesToolStripDropDownBtn.Text = "Rules"
            ToolTipInfo153.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo153.Body.Hidden = True
            ToolTipInfo153.Footer.Hidden = True
            ToolTipInfo153.Header.Text = "Rules"
            ToolTipInfo153.Separator = False
            Me.superToolTip1.SetToolTip(Me.rulesToolStripDropDownBtn, ToolTipInfo153)
            '
            'matchFieldsToolStripBtn
            '
            Me.matchFieldsToolStripBtn.Enabled = False
            Me.matchFieldsToolStripBtn.Image = CType(resources.GetObject("matchFieldsToolStripBtn.Image"), System.Drawing.Image)
            Me.matchFieldsToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.matchFieldsToolStripBtn.Name = "matchFieldsToolStripBtn"
            Me.matchFieldsToolStripBtn.Size = New System.Drawing.Size(86, 20)
            Me.matchFieldsToolStripBtn.Text = "Match Fields"
            ToolTipInfo154.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo154.Body.Hidden = True
            ToolTipInfo154.Footer.Hidden = True
            ToolTipInfo154.Header.Text = "Match Fields"
            ToolTipInfo154.Separator = False
            Me.superToolTip1.SetToolTip(Me.matchFieldsToolStripBtn, ToolTipInfo154)
            '
            'upLablesToolStripBtn
            '
            Me.upLablesToolStripBtn.Enabled = False
            Me.upLablesToolStripBtn.Image = CType(resources.GetObject("upLablesToolStripBtn.Image"), System.Drawing.Image)
            Me.upLablesToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.upLablesToolStripBtn.Name = "upLablesToolStripBtn"
            Me.upLablesToolStripBtn.Size = New System.Drawing.Size(95, 20)
            Me.upLablesToolStripBtn.Text = "Update Labels"
            ToolTipInfo155.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo155.Body.Hidden = True
            ToolTipInfo155.Footer.Hidden = True
            ToolTipInfo155.Header.Text = "Update Labels"
            ToolTipInfo155.Separator = False
            Me.superToolTip1.SetToolTip(Me.upLablesToolStripBtn, ToolTipInfo155)
            '
            'previewResultsToolStripExt
            '
            Me.previewResultsToolStripExt.CollapsedDropDownButtonText = "Preview"
            Me.previewResultsToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.previewResultsToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.previewResultsToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.previewResultsToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.previewResultsToolStripExt.Image = CType(resources.GetObject("previewResultsToolStripExt.Image"), System.Drawing.Image)
            Me.previewResultsToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.previewResultsToolStripBtn, Me.toolStripSeparator22, Me.toolStripPanelItem33})
            Me.previewResultsToolStripExt.Location = New System.Drawing.Point(690, 1)
            Me.previewResultsToolStripExt.Name = "previewResultsToolStripExt"
            Me.previewResultsToolStripExt.ShowLauncher = False
            Me.previewResultsToolStripExt.Size = New System.Drawing.Size(238, 0)
            Me.previewResultsToolStripExt.TabIndex = 3
            Me.previewResultsToolStripExt.Text = "Preview Results"
            '
            'previewResultsToolStripBtn
            '
            Me.previewResultsToolStripBtn.Enabled = False
            Me.previewResultsToolStripBtn.Image = CType(resources.GetObject("previewResultsToolStripBtn.Image"), System.Drawing.Image)
            Me.previewResultsToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.previewResultsToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.previewResultsToolStripBtn.Name = "previewResultsToolStripBtn"
            Me.previewResultsToolStripBtn.Size = New System.Drawing.Size(49, 0)
            Me.previewResultsToolStripBtn.Text = "Preview" & Global.Microsoft.VisualBasic.ChrW(10) & "Results"
            Me.previewResultsToolStripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo156.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo156.Body.Hidden = True
            ToolTipInfo156.Footer.Hidden = True
            ToolTipInfo156.Header.Text = "Preview Results"
            ToolTipInfo156.Separator = False
            Me.superToolTip1.SetToolTip(Me.previewResultsToolStripBtn, ToolTipInfo156)
            '
            'toolStripSeparator22
            '
            Me.toolStripSeparator22.Name = "toolStripSeparator22"
            Me.toolStripSeparator22.Size = New System.Drawing.Size(6, 0)
            '
            'toolStripPanelItem33
            '
            Me.toolStripPanelItem33.CausesValidation = False
            Me.toolStripPanelItem33.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem33.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem34, Me.fndRecepientToolStripBtn, Me.checkErrorToolStripBtn})
            Me.toolStripPanelItem33.Name = "toolStripPanelItem33"
            Me.toolStripPanelItem33.Size = New System.Drawing.Size(149, 0)
            Me.toolStripPanelItem33.Text = "toolStripPanelItem33"
            Me.toolStripPanelItem33.Transparent = True
            '
            'toolStripPanelItem34
            '
            Me.toolStripPanelItem34.CausesValidation = False
            Me.toolStripPanelItem34.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem34.GroupedButtons = True
            Me.toolStripPanelItem34.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.firstToolStripBtn, Me.previousToolStripBtn, Me.recordToolStripTextBox, Me.nxtToolStripBtn, Me.lstToolStripBtn})
            Me.toolStripPanelItem34.Name = "toolStripPanelItem34"
            Me.toolStripPanelItem34.RowCount = 1
            Me.toolStripPanelItem34.Size = New System.Drawing.Size(143, 27)
            Me.toolStripPanelItem34.Text = "toolStripPanelItem34"
            Me.toolStripPanelItem34.Transparent = True
            '
            'firstToolStripBtn
            '
            Me.firstToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.firstToolStripBtn.Enabled = False
            Me.firstToolStripBtn.Image = CType(resources.GetObject("firstToolStripBtn.Image"), System.Drawing.Image)
            Me.firstToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.firstToolStripBtn.Name = "firstToolStripBtn"
            Me.firstToolStripBtn.Size = New System.Drawing.Size(23, 20)
            Me.firstToolStripBtn.Text = "firstToolStripBtn"
            ToolTipInfo157.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo157.Header.Text = "First"
            Me.superToolTip1.SetToolTip(Me.firstToolStripBtn, ToolTipInfo157)
            '
            'previousToolStripBtn
            '
            Me.previousToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.previousToolStripBtn.Enabled = False
            Me.previousToolStripBtn.Image = CType(resources.GetObject("previousToolStripBtn.Image"), System.Drawing.Image)
            Me.previousToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.previousToolStripBtn.Name = "previousToolStripBtn"
            Me.previousToolStripBtn.Size = New System.Drawing.Size(23, 20)
            Me.previousToolStripBtn.Text = "previousToolStripBtn"
            ToolTipInfo158.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo158.Header.Text = "Previous"
            Me.superToolTip1.SetToolTip(Me.previousToolStripBtn, ToolTipInfo158)
            '
            'recordToolStripTextBox
            '
            Me.recordToolStripTextBox.Enabled = False
            Me.recordToolStripTextBox.Name = "recordToolStripTextBox"
            Me.recordToolStripTextBox.Size = New System.Drawing.Size(45, 21)
            '
            'nxtToolStripBtn
            '
            Me.nxtToolStripBtn.Enabled = False
            Me.nxtToolStripBtn.Image = CType(resources.GetObject("nxtToolStripBtn.Image"), System.Drawing.Image)
            Me.nxtToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.nxtToolStripBtn.Name = "nxtToolStripBtn"
            Me.nxtToolStripBtn.Size = New System.Drawing.Size(23, 20)
            ToolTipInfo159.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo159.Header.Text = "Next"
            Me.superToolTip1.SetToolTip(Me.nxtToolStripBtn, ToolTipInfo159)
            '
            'lstToolStripBtn
            '
            Me.lstToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.lstToolStripBtn.Enabled = False
            Me.lstToolStripBtn.Image = CType(resources.GetObject("lstToolStripBtn.Image"), System.Drawing.Image)
            Me.lstToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.lstToolStripBtn.Name = "lstToolStripBtn"
            Me.lstToolStripBtn.Size = New System.Drawing.Size(23, 20)
            Me.lstToolStripBtn.Text = "lstToolStripBtn"
            ToolTipInfo160.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo160.Header.Text = "Last"
            Me.superToolTip1.SetToolTip(Me.lstToolStripBtn, ToolTipInfo160)
            '
            'fndRecepientToolStripBtn
            '
            Me.fndRecepientToolStripBtn.Enabled = False
            Me.fndRecepientToolStripBtn.Image = CType(resources.GetObject("fndRecepientToolStripBtn.Image"), System.Drawing.Image)
            Me.fndRecepientToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.fndRecepientToolStripBtn.Name = "fndRecepientToolStripBtn"
            Me.fndRecepientToolStripBtn.Size = New System.Drawing.Size(94, 20)
            Me.fndRecepientToolStripBtn.Text = "Find Recipient"
            ToolTipInfo161.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo161.Body.Hidden = True
            ToolTipInfo161.Footer.Hidden = True
            ToolTipInfo161.Header.Text = "Find Recipient"
            ToolTipInfo161.Separator = False
            Me.superToolTip1.SetToolTip(Me.fndRecepientToolStripBtn, ToolTipInfo161)
            '
            'checkErrorToolStripBtn
            '
            Me.checkErrorToolStripBtn.Enabled = False
            Me.checkErrorToolStripBtn.Image = CType(resources.GetObject("checkErrorToolStripBtn.Image"), System.Drawing.Image)
            Me.checkErrorToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.checkErrorToolStripBtn.Name = "checkErrorToolStripBtn"
            Me.checkErrorToolStripBtn.Size = New System.Drawing.Size(131, 20)
            Me.checkErrorToolStripBtn.Text = "Auto Check for Errors"
            ToolTipInfo162.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo162.Body.Hidden = True
            ToolTipInfo162.Footer.Hidden = True
            ToolTipInfo162.Header.Text = "Auto Check for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Errors"
            ToolTipInfo162.Separator = False
            Me.superToolTip1.SetToolTip(Me.checkErrorToolStripBtn, ToolTipInfo162)
            '
            'finishToolStripExt
            '
            Me.finishToolStripExt.CollapsedDropDownButtonText = "Finish"
            Me.finishToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.finishToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.finishToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.finishToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.finishToolStripExt.Image = CType(resources.GetObject("finishToolStripExt.Image"), System.Drawing.Image)
            Me.finishToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.finshMergeToolStripDropDownBtn})
            Me.finishToolStripExt.Location = New System.Drawing.Point(928, 1)
            Me.finishToolStripExt.Name = "finishToolStripExt"
            Me.finishToolStripExt.ShowLauncher = False
            Me.finishToolStripExt.Size = New System.Drawing.Size(65, 0)
            Me.finishToolStripExt.TabIndex = 4
            Me.finishToolStripExt.Text = "Finish"
            '
            'finshMergeToolStripDropDownBtn
            '
            Me.finshMergeToolStripDropDownBtn.Enabled = False
            Me.finshMergeToolStripDropDownBtn.Image = CType(resources.GetObject("finshMergeToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.finshMergeToolStripDropDownBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.finshMergeToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.finshMergeToolStripDropDownBtn.Name = "finshMergeToolStripDropDownBtn"
            Me.finshMergeToolStripDropDownBtn.Size = New System.Drawing.Size(57, 0)
            Me.finshMergeToolStripDropDownBtn.Text = "Finish &&" & Global.Microsoft.VisualBasic.ChrW(10) & "Merge"
            Me.finshMergeToolStripDropDownBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo163.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo163.Body.Hidden = True
            ToolTipInfo163.Footer.Hidden = True
            ToolTipInfo163.Header.Text = "Finish && Merge"
            ToolTipInfo163.Separator = False
            Me.superToolTip1.SetToolTip(Me.finshMergeToolStripDropDownBtn, ToolTipInfo163)
            '
            'reviewTabItem
            '
            Me.superAccelerator.SetAccelerator(Me.reviewTabItem, "R")
            Me.reviewTabItem.ForeColor = System.Drawing.Color.MidnightBlue
            Me.reviewTabItem.Name = "reviewTabItem"
            Me.reviewTabItem.Padding = New System.Windows.Forms.Padding(15, 2, 3, 5)
            '
            'ribbonControlAdv1.RibbonPanel6
            '
            Me.reviewTabItem.Panel.Controls.Add(Me.proofingToolStripExt)
            Me.reviewTabItem.Panel.Controls.Add(Me.commentsToolStripExt)
            Me.reviewTabItem.Panel.Controls.Add(Me.trackingToolStripExt)
            Me.reviewTabItem.Panel.Controls.Add(Me.changesToolStripExt)
            Me.reviewTabItem.Panel.Controls.Add(Me.compareToolStripExt)
            Me.reviewTabItem.Panel.Controls.Add(Me.toolStripEx6)
            Me.reviewTabItem.Panel.Name = "RibbonPanel6"
            Me.reviewTabItem.Panel.ScrollPosition = 0
            Me.reviewTabItem.Panel.TabIndex = 6
            Me.reviewTabItem.Panel.Text = "Review"
            Me.reviewTabItem.Size = New System.Drawing.Size(64, 24)
            Me.reviewTabItem.Text = "Review"
            '
            'proofingToolStripExt
            '
            Me.proofingToolStripExt.CollapsedDropDownButtonText = "Proofing"
            Me.proofingToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.proofingToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.proofingToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.proofingToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.proofingToolStripExt.Image = CType(resources.GetObject("proofingToolStripExt.Image"), System.Drawing.Image)
            Me.proofingToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.spellToolStripBtn, Me.toolStripPanelItem35, Me.toolStripPanelItem36})
            Me.proofingToolStripExt.Location = New System.Drawing.Point(0, 1)
            Me.proofingToolStripExt.Name = "proofingToolStripExt"
            Me.proofingToolStripExt.ShowLauncher = False
            Me.proofingToolStripExt.Size = New System.Drawing.Size(280, 0)
            Me.proofingToolStripExt.TabIndex = 0
            Me.proofingToolStripExt.Text = "Proofing"
            '
            'spellToolStripBtn
            '
            Me.spellToolStripBtn.Image = CType(resources.GetObject("spellToolStripBtn.Image"), System.Drawing.Image)
            Me.spellToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.spellToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.spellToolStripBtn.Name = "spellToolStripBtn"
            Me.spellToolStripBtn.Size = New System.Drawing.Size(57, 0)
            Me.spellToolStripBtn.Text = "Spelling &&" & Global.Microsoft.VisualBasic.ChrW(10) & "Grammar"
            Me.spellToolStripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo164.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo164.Body.Hidden = True
            ToolTipInfo164.Footer.Hidden = True
            ToolTipInfo164.Header.Text = "Spelling && Grammar"
            ToolTipInfo164.Separator = False
            Me.superToolTip1.SetToolTip(Me.spellToolStripBtn, ToolTipInfo164)
            '
            'toolStripPanelItem35
            '
            Me.toolStripPanelItem35.CausesValidation = False
            Me.toolStripPanelItem35.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem35.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.researchToolStripBtn, Me.thesaurusToolStripBtn, Me.translateToolStripBtn})
            Me.toolStripPanelItem35.Name = "toolStripPanelItem35"
            Me.toolStripPanelItem35.Size = New System.Drawing.Size(81, 0)
            Me.toolStripPanelItem35.Text = "toolStripPanelItem35"
            Me.toolStripPanelItem35.Transparent = True
            '
            'researchToolStripBtn
            '
            Me.researchToolStripBtn.Image = CType(resources.GetObject("researchToolStripBtn.Image"), System.Drawing.Image)
            Me.researchToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.researchToolStripBtn.Name = "researchToolStripBtn"
            Me.researchToolStripBtn.Size = New System.Drawing.Size(72, 20)
            Me.researchToolStripBtn.Text = "Research"
            ToolTipInfo165.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo165.Body.Hidden = True
            ToolTipInfo165.Footer.Hidden = True
            ToolTipInfo165.Header.Text = "Research"
            ToolTipInfo165.Separator = False
            Me.superToolTip1.SetToolTip(Me.researchToolStripBtn, ToolTipInfo165)
            '
            'thesaurusToolStripBtn
            '
            Me.thesaurusToolStripBtn.Image = CType(resources.GetObject("thesaurusToolStripBtn.Image"), System.Drawing.Image)
            Me.thesaurusToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.thesaurusToolStripBtn.Name = "thesaurusToolStripBtn"
            Me.thesaurusToolStripBtn.Size = New System.Drawing.Size(77, 20)
            Me.thesaurusToolStripBtn.Text = "Thesaurus"
            ToolTipInfo166.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo166.Body.Hidden = True
            ToolTipInfo166.Footer.Hidden = True
            ToolTipInfo166.Footer.Text = ""
            ToolTipInfo166.Header.Text = "Thesaurus"
            ToolTipInfo166.Separator = False
            Me.superToolTip1.SetToolTip(Me.thesaurusToolStripBtn, ToolTipInfo166)
            '
            'translateToolStripBtn
            '
            Me.translateToolStripBtn.Image = CType(resources.GetObject("translateToolStripBtn.Image"), System.Drawing.Image)
            Me.translateToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.translateToolStripBtn.Name = "translateToolStripBtn"
            Me.translateToolStripBtn.Size = New System.Drawing.Size(72, 20)
            Me.translateToolStripBtn.Text = "Translate"
            ToolTipInfo167.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo167.Body.Hidden = True
            ToolTipInfo167.Footer.Hidden = True
            ToolTipInfo167.Header.Text = "Translate"
            ToolTipInfo167.Separator = False
            Me.superToolTip1.SetToolTip(Me.translateToolStripBtn, ToolTipInfo167)
            '
            'toolStripPanelItem36
            '
            Me.toolStripPanelItem36.CausesValidation = False
            Me.toolStripPanelItem36.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem36.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.translateTooltipToolStripDropDownBtn, Me.setLangToolStripBtn, Me.wordCntToolStripBtn})
            Me.toolStripPanelItem36.Name = "toolStripPanelItem36"
            Me.toolStripPanelItem36.Size = New System.Drawing.Size(133, 0)
            Me.toolStripPanelItem36.Text = "toolStripPanelItem36"
            Me.toolStripPanelItem36.Transparent = True
            '
            'translateTooltipToolStripDropDownBtn
            '
            Me.translateTooltipToolStripDropDownBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.englishUSToolStripMenuItem, Me.toolStripMenuItem8, Me.spanishInternationalSortToolStripMenuItem, Me.turnOffTranslationToolTipToolStripMenuItem, Me.turnOffTranslationTooltipToolStripMenuItem1})
            Me.translateTooltipToolStripDropDownBtn.Image = CType(resources.GetObject("translateTooltipToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.translateTooltipToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.translateTooltipToolStripDropDownBtn.Name = "translateTooltipToolStripDropDownBtn"
            Me.translateTooltipToolStripDropDownBtn.Size = New System.Drawing.Size(129, 20)
            Me.translateTooltipToolStripDropDownBtn.Text = "Translation Tool Tip"
            ToolTipInfo168.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo168.Body.Hidden = True
            ToolTipInfo168.Footer.Hidden = True
            ToolTipInfo168.Header.Text = "Translation ToolTip"
            ToolTipInfo168.Separator = False
            Me.superToolTip1.SetToolTip(Me.translateTooltipToolStripDropDownBtn, ToolTipInfo168)
            '
            'englishUSToolStripMenuItem
            '
            Me.englishUSToolStripMenuItem.Name = "englishUSToolStripMenuItem"
            Me.englishUSToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
            Me.englishUSToolStripMenuItem.Text = "Arabic (Saudi Arabia)"
            '
            'toolStripMenuItem8
            '
            Me.toolStripMenuItem8.Name = "toolStripMenuItem8"
            Me.toolStripMenuItem8.Size = New System.Drawing.Size(232, 22)
            Me.toolStripMenuItem8.Text = "English (U.S.)"
            '
            'spanishInternationalSortToolStripMenuItem
            '
            Me.spanishInternationalSortToolStripMenuItem.Name = "spanishInternationalSortToolStripMenuItem"
            Me.spanishInternationalSortToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
            Me.spanishInternationalSortToolStripMenuItem.Text = "French (France)"
            '
            'turnOffTranslationToolTipToolStripMenuItem
            '
            Me.turnOffTranslationToolTipToolStripMenuItem.Name = "turnOffTranslationToolTipToolStripMenuItem"
            Me.turnOffTranslationToolTipToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
            Me.turnOffTranslationToolTipToolStripMenuItem.Text = "Spanish (International Sort)"
            '
            'turnOffTranslationTooltipToolStripMenuItem1
            '
            Me.turnOffTranslationTooltipToolStripMenuItem1.Checked = True
            Me.turnOffTranslationTooltipToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.turnOffTranslationTooltipToolStripMenuItem1.Name = "turnOffTranslationTooltipToolStripMenuItem1"
            Me.turnOffTranslationTooltipToolStripMenuItem1.Size = New System.Drawing.Size(232, 22)
            Me.turnOffTranslationTooltipToolStripMenuItem1.Text = "Turn Off Translation ScreenTip"
            '
            'setLangToolStripBtn
            '
            Me.setLangToolStripBtn.Image = CType(resources.GetObject("setLangToolStripBtn.Image"), System.Drawing.Image)
            Me.setLangToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.setLangToolStripBtn.Name = "setLangToolStripBtn"
            Me.setLangToolStripBtn.Size = New System.Drawing.Size(93, 20)
            Me.setLangToolStripBtn.Text = "Set Language"
            ToolTipInfo169.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo169.Body.Hidden = True
            ToolTipInfo169.Footer.Hidden = True
            ToolTipInfo169.Header.Text = "Set Language"
            ToolTipInfo169.Separator = False
            Me.superToolTip1.SetToolTip(Me.setLangToolStripBtn, ToolTipInfo169)
            '
            'wordCntToolStripBtn
            '
            Me.wordCntToolStripBtn.Image = CType(resources.GetObject("wordCntToolStripBtn.Image"), System.Drawing.Image)
            Me.wordCntToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.wordCntToolStripBtn.Name = "wordCntToolStripBtn"
            Me.wordCntToolStripBtn.Size = New System.Drawing.Size(85, 20)
            Me.wordCntToolStripBtn.Text = "Word Count"
            ToolTipInfo170.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo170.Body.Hidden = True
            ToolTipInfo170.Footer.Hidden = True
            ToolTipInfo170.Header.Text = "Word Count"
            ToolTipInfo170.Separator = False
            Me.superToolTip1.SetToolTip(Me.wordCntToolStripBtn, ToolTipInfo170)
            '
            'commentsToolStripExt
            '
            Me.commentsToolStripExt.AutoSize = False
            Me.commentsToolStripExt.CollapsedDropDownButtonText = "Comments"
            Me.commentsToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.commentsToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.commentsToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.commentsToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.commentsToolStripExt.Image = CType(resources.GetObject("commentsToolStripExt.Image"), System.Drawing.Image)
            Me.commentsToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nwCommentToolStripBtn, Me.toolStripPanelItem37})
            Me.commentsToolStripExt.Location = New System.Drawing.Point(280, 1)
            Me.commentsToolStripExt.Name = "commentsToolStripExt"
            Me.commentsToolStripExt.Size = New System.Drawing.Size(137, 0)
            Me.commentsToolStripExt.TabIndex = 1
            Me.commentsToolStripExt.Text = "Comments"
            '
            'nwCommentToolStripBtn
            '
            Me.nwCommentToolStripBtn.Image = CType(resources.GetObject("nwCommentToolStripBtn.Image"), System.Drawing.Image)
            Me.nwCommentToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.nwCommentToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.nwCommentToolStripBtn.Name = "nwCommentToolStripBtn"
            Me.nwCommentToolStripBtn.Size = New System.Drawing.Size(56, 0)
            Me.nwCommentToolStripBtn.Text = "New" & Global.Microsoft.VisualBasic.ChrW(10) & "Comment"
            Me.nwCommentToolStripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo171.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo171.Body.Hidden = True
            ToolTipInfo171.Footer.Hidden = True
            ToolTipInfo171.Header.Text = "New Comment"
            ToolTipInfo171.Separator = False
            Me.superToolTip1.SetToolTip(Me.nwCommentToolStripBtn, ToolTipInfo171)
            '
            'toolStripPanelItem37
            '
            Me.toolStripPanelItem37.CausesValidation = False
            Me.toolStripPanelItem37.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem37.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.delToolStripDropDownBtn, Me.preToolStripBtn, Me.nxttToolStripBtn})
            Me.toolStripPanelItem37.Name = "toolStripPanelItem37"
            Me.toolStripPanelItem37.Size = New System.Drawing.Size(72, 0)
            Me.toolStripPanelItem37.Text = "toolStripPanelItem37"
            Me.toolStripPanelItem37.Transparent = True
            '
            'delToolStripDropDownBtn
            '
            Me.delToolStripDropDownBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.deleteToolStripMenuItem, Me.deleteAllCommentsShownToolStripMenuItem, Me.deleteAllCommentsInDocumentToolStripMenuItem})
            Me.delToolStripDropDownBtn.Enabled = False
            Me.delToolStripDropDownBtn.Image = CType(resources.GetObject("delToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.delToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.delToolStripDropDownBtn.Name = "delToolStripDropDownBtn"
            Me.delToolStripDropDownBtn.Size = New System.Drawing.Size(67, 20)
            Me.delToolStripDropDownBtn.Text = "Delete"
            ToolTipInfo172.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo172.Body.Hidden = True
            ToolTipInfo172.Footer.Hidden = True
            ToolTipInfo172.Header.Text = "Delete"
            ToolTipInfo172.Separator = False
            Me.superToolTip1.SetToolTip(Me.delToolStripDropDownBtn, ToolTipInfo172)
            '
            'deleteToolStripMenuItem
            '
            Me.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem"
            Me.deleteToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
            Me.deleteToolStripMenuItem.Text = "&Delete"
            '
            'deleteAllCommentsShownToolStripMenuItem
            '
            Me.deleteAllCommentsShownToolStripMenuItem.Enabled = False
            Me.deleteAllCommentsShownToolStripMenuItem.Name = "deleteAllCommentsShownToolStripMenuItem"
            Me.deleteAllCommentsShownToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
            Me.deleteAllCommentsShownToolStripMenuItem.Text = "Delete &All Comments Shown"
            '
            'deleteAllCommentsInDocumentToolStripMenuItem
            '
            Me.deleteAllCommentsInDocumentToolStripMenuItem.Name = "deleteAllCommentsInDocumentToolStripMenuItem"
            Me.deleteAllCommentsInDocumentToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
            Me.deleteAllCommentsInDocumentToolStripMenuItem.Text = "Delete All C&omments in Document"
            '
            'preToolStripBtn
            '
            Me.preToolStripBtn.Enabled = False
            Me.preToolStripBtn.Image = CType(resources.GetObject("preToolStripBtn.Image"), System.Drawing.Image)
            Me.preToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.preToolStripBtn.Name = "preToolStripBtn"
            Me.preToolStripBtn.Size = New System.Drawing.Size(68, 20)
            Me.preToolStripBtn.Text = "Previous"
            ToolTipInfo173.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo173.Body.Hidden = True
            ToolTipInfo173.Footer.Hidden = True
            ToolTipInfo173.Header.Text = "Previous"
            ToolTipInfo173.Separator = False
            Me.superToolTip1.SetToolTip(Me.preToolStripBtn, ToolTipInfo173)
            '
            'nxttToolStripBtn
            '
            Me.nxttToolStripBtn.Enabled = False
            Me.nxttToolStripBtn.Image = CType(resources.GetObject("nxttToolStripBtn.Image"), System.Drawing.Image)
            Me.nxttToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.nxttToolStripBtn.Name = "nxttToolStripBtn"
            Me.nxttToolStripBtn.Size = New System.Drawing.Size(50, 20)
            Me.nxttToolStripBtn.Text = "Next"
            ToolTipInfo174.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo174.Body.Hidden = True
            ToolTipInfo174.Footer.Hidden = True
            ToolTipInfo174.Header.Text = "Next"
            ToolTipInfo174.Separator = False
            Me.superToolTip1.SetToolTip(Me.nxttToolStripBtn, ToolTipInfo174)
            '
            'trackingToolStripExt
            '
            Me.trackingToolStripExt.CollapsedDropDownButtonText = "Tracking"
            Me.trackingToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.trackingToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.trackingToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.trackingToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.trackingToolStripExt.Image = CType(resources.GetObject("trackingToolStripExt.Image"), System.Drawing.Image)
            Me.trackingToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.trkChangesToolStripSplitButton, Me.balloonsToolStripDropDownBtn, Me.toolStripPanelItem38})
            Me.trackingToolStripExt.Location = New System.Drawing.Point(417, 1)
            Me.trackingToolStripExt.Name = "trackingToolStripExt"
            Me.trackingToolStripExt.ShowLauncher = False
            Me.trackingToolStripExt.Size = New System.Drawing.Size(250, 0)
            Me.trackingToolStripExt.TabIndex = 2
            Me.trackingToolStripExt.Text = "Tracking"
            '
            'trkChangesToolStripSplitButton
            '
            Me.trkChangesToolStripSplitButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.trackChangesToolStripMenuItem, Me.changeTrackingOptionsToolStripMenuItem, Me.changeUserNameToolStripMenuItem})
            Me.trkChangesToolStripSplitButton.Image = CType(resources.GetObject("trkChangesToolStripSplitButton.Image"), System.Drawing.Image)
            Me.trkChangesToolStripSplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.trkChangesToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.trkChangesToolStripSplitButton.Name = "trkChangesToolStripSplitButton"
            Me.trkChangesToolStripSplitButton.Size = New System.Drawing.Size(65, 0)
            Me.trkChangesToolStripSplitButton.Text = "Track" & Global.Microsoft.VisualBasic.ChrW(10) & "Changes"
            Me.trkChangesToolStripSplitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo175.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo175.Body.Hidden = True
            ToolTipInfo175.Footer.Hidden = True
            ToolTipInfo175.Header.Text = "Track Changes"
            ToolTipInfo175.Separator = False
            Me.superToolTip1.SetToolTip(Me.trkChangesToolStripSplitButton, ToolTipInfo175)
            '
            'trackChangesToolStripMenuItem
            '
            Me.trackChangesToolStripMenuItem.Name = "trackChangesToolStripMenuItem"
            Me.trackChangesToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
            Me.trackChangesToolStripMenuItem.Text = "&Track Changes"
            '
            'changeTrackingOptionsToolStripMenuItem
            '
            Me.changeTrackingOptionsToolStripMenuItem.Name = "changeTrackingOptionsToolStripMenuItem"
            Me.changeTrackingOptionsToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
            Me.changeTrackingOptionsToolStripMenuItem.Text = "Change Tracking &Options..."
            '
            'changeUserNameToolStripMenuItem
            '
            Me.changeUserNameToolStripMenuItem.Name = "changeUserNameToolStripMenuItem"
            Me.changeUserNameToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
            Me.changeUserNameToolStripMenuItem.Text = "Change &User Name..."
            '
            'balloonsToolStripDropDownBtn
            '
            Me.balloonsToolStripDropDownBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.showRevisionsInballoonsToolStripMenuItem, Me.showAllRevisionsInlineToolStripMenuItem, Me.showOnlycommentsAndFormattingInBallonsToolStripMenuItem})
            Me.balloonsToolStripDropDownBtn.Image = CType(resources.GetObject("balloonsToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.balloonsToolStripDropDownBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.balloonsToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.balloonsToolStripDropDownBtn.Name = "balloonsToolStripDropDownBtn"
            Me.balloonsToolStripDropDownBtn.Size = New System.Drawing.Size(59, 0)
            Me.balloonsToolStripDropDownBtn.Text = "Balloons"
            Me.balloonsToolStripDropDownBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo176.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo176.Header.Text = "Balloons"
            Me.superToolTip1.SetToolTip(Me.balloonsToolStripDropDownBtn, ToolTipInfo176)
            '
            'showRevisionsInballoonsToolStripMenuItem
            '
            Me.showRevisionsInballoonsToolStripMenuItem.Name = "showRevisionsInballoonsToolStripMenuItem"
            Me.showRevisionsInballoonsToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
            Me.showRevisionsInballoonsToolStripMenuItem.Text = "Show revisions in &balloons"
            '
            'showAllRevisionsInlineToolStripMenuItem
            '
            Me.showAllRevisionsInlineToolStripMenuItem.Name = "showAllRevisionsInlineToolStripMenuItem"
            Me.showAllRevisionsInlineToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
            Me.showAllRevisionsInlineToolStripMenuItem.Text = "Show all rev&isions inline"
            '
            'showOnlycommentsAndFormattingInBallonsToolStripMenuItem
            '
            Me.showOnlycommentsAndFormattingInBallonsToolStripMenuItem.Checked = True
            Me.showOnlycommentsAndFormattingInBallonsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.showOnlycommentsAndFormattingInBallonsToolStripMenuItem.Name = "showOnlycommentsAndFormattingInBallonsToolStripMenuItem"
            Me.showOnlycommentsAndFormattingInBallonsToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
            Me.showOnlycommentsAndFormattingInBallonsToolStripMenuItem.Text = "Show only &comments and formatting in balloons"
            '
            'toolStripPanelItem38
            '
            Me.toolStripPanelItem38.CausesValidation = False
            Me.toolStripPanelItem38.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem38.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripReviewComboBox, Me.shMarkUpToolStripDropDownBtn, Me.reviewPaneToolStripSplitButton})
            Me.toolStripPanelItem38.Name = "toolStripPanelItem38"
            Me.toolStripPanelItem38.Size = New System.Drawing.Size(119, 0)
            Me.toolStripPanelItem38.Text = "toolStripPanelItem38"
            Me.toolStripPanelItem38.Transparent = True
            '
            'toolStripReviewComboBox
            '
            Me.toolStripReviewComboBox.Name = "toolStripReviewComboBox"
            Me.toolStripReviewComboBox.Size = New System.Drawing.Size(75, 21)
            '
            'shMarkUpToolStripDropDownBtn
            '
            Me.shMarkUpToolStripDropDownBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.commentsToolStripMenuItem1, Me.inkToolStripMenuItem, Me.insertionsAndDeletionsToolStripMenuItem, Me.formattingToolStripMenuItem, Me.markupAreaHighlightToolStripMenuItem, Me.revieToolStripMenuItem})
            Me.shMarkUpToolStripDropDownBtn.Image = CType(resources.GetObject("shMarkUpToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.shMarkUpToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.shMarkUpToolStripDropDownBtn.Name = "shMarkUpToolStripDropDownBtn"
            Me.shMarkUpToolStripDropDownBtn.Size = New System.Drawing.Size(100, 20)
            Me.shMarkUpToolStripDropDownBtn.Text = "Show Markup"
            ToolTipInfo177.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo177.Header.Text = "Show Markup"
            Me.superToolTip1.SetToolTip(Me.shMarkUpToolStripDropDownBtn, ToolTipInfo177)
            '
            'commentsToolStripMenuItem1
            '
            Me.commentsToolStripMenuItem1.Checked = True
            Me.commentsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.commentsToolStripMenuItem1.Name = "commentsToolStripMenuItem1"
            Me.commentsToolStripMenuItem1.Size = New System.Drawing.Size(201, 22)
            Me.commentsToolStripMenuItem1.Text = "&Comments"
            '
            'inkToolStripMenuItem
            '
            Me.inkToolStripMenuItem.Checked = True
            Me.inkToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.inkToolStripMenuItem.Name = "inkToolStripMenuItem"
            Me.inkToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.inkToolStripMenuItem.Text = "In&k"
            '
            'insertionsAndDeletionsToolStripMenuItem
            '
            Me.insertionsAndDeletionsToolStripMenuItem.Checked = True
            Me.insertionsAndDeletionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.insertionsAndDeletionsToolStripMenuItem.Name = "insertionsAndDeletionsToolStripMenuItem"
            Me.insertionsAndDeletionsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.insertionsAndDeletionsToolStripMenuItem.Text = "&Insertions and Deletions"
            '
            'formattingToolStripMenuItem
            '
            Me.formattingToolStripMenuItem.Checked = True
            Me.formattingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.formattingToolStripMenuItem.Name = "formattingToolStripMenuItem"
            Me.formattingToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.formattingToolStripMenuItem.Text = "&Formatting"
            '
            'markupAreaHighlightToolStripMenuItem
            '
            Me.markupAreaHighlightToolStripMenuItem.Checked = True
            Me.markupAreaHighlightToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.markupAreaHighlightToolStripMenuItem.Name = "markupAreaHighlightToolStripMenuItem"
            Me.markupAreaHighlightToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.markupAreaHighlightToolStripMenuItem.Text = "Markup Area &Highlight"
            '
            'revieToolStripMenuItem
            '
            Me.revieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.allReviewersToolStripMenuItem})
            Me.revieToolStripMenuItem.Name = "revieToolStripMenuItem"
            Me.revieToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.revieToolStripMenuItem.Text = "&Reviewers..."
            '
            'allReviewersToolStripMenuItem
            '
            Me.allReviewersToolStripMenuItem.Checked = True
            Me.allReviewersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.allReviewersToolStripMenuItem.Name = "allReviewersToolStripMenuItem"
            Me.allReviewersToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
            Me.allReviewersToolStripMenuItem.Text = "&All Reviewers"
            '
            'reviewPaneToolStripSplitButton
            '
            Me.reviewPaneToolStripSplitButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.reviewingPaneVerticalToolStripMenuItem, Me.reviewingPaneHorizontalToolStripMenuItem})
            Me.reviewPaneToolStripSplitButton.Image = CType(resources.GetObject("reviewPaneToolStripSplitButton.Image"), System.Drawing.Image)
            Me.reviewPaneToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.reviewPaneToolStripSplitButton.Name = "reviewPaneToolStripSplitButton"
            Me.reviewPaneToolStripSplitButton.Size = New System.Drawing.Size(115, 20)
            Me.reviewPaneToolStripSplitButton.Text = "Reviewing Pane"
            ToolTipInfo178.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo178.Header.Text = "Reviewing Pane"
            Me.superToolTip1.SetToolTip(Me.reviewPaneToolStripSplitButton, ToolTipInfo178)
            '
            'reviewingPaneVerticalToolStripMenuItem
            '
            Me.reviewingPaneVerticalToolStripMenuItem.Name = "reviewingPaneVerticalToolStripMenuItem"
            Me.reviewingPaneVerticalToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
            Me.reviewingPaneVerticalToolStripMenuItem.Text = "Reviewing Pane &Vertical..."
            '
            'reviewingPaneHorizontalToolStripMenuItem
            '
            Me.reviewingPaneHorizontalToolStripMenuItem.Name = "reviewingPaneHorizontalToolStripMenuItem"
            Me.reviewingPaneHorizontalToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
            Me.reviewingPaneHorizontalToolStripMenuItem.Text = "Reviewing Pane &Horizontal..."
            '
            'changesToolStripExt
            '
            Me.changesToolStripExt.CollapsedDropDownButtonText = "Changes"
            Me.changesToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.changesToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.changesToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.changesToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.changesToolStripExt.Image = CType(resources.GetObject("changesToolStripExt.Image"), System.Drawing.Image)
            Me.changesToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.acceptToolStripSplitButton, Me.toolStripPanelItem39})
            Me.changesToolStripExt.Location = New System.Drawing.Point(667, 1)
            Me.changesToolStripExt.Name = "changesToolStripExt"
            Me.changesToolStripExt.ShowLauncher = False
            Me.changesToolStripExt.Size = New System.Drawing.Size(137, 0)
            Me.changesToolStripExt.TabIndex = 3
            Me.changesToolStripExt.Text = "Changes"
            '
            'acceptToolStripSplitButton
            '
            Me.acceptToolStripSplitButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.acceptAndMoveToNextToolStripMenuItem, Me.acceptChangeToolStripMenuItem, Me.acceptAllChangesShownToolStripMenuItem, Me.acceptAllChangesInDocumentToolStripMenuItem})
            Me.acceptToolStripSplitButton.Image = CType(resources.GetObject("acceptToolStripSplitButton.Image"), System.Drawing.Image)
            Me.acceptToolStripSplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.acceptToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.acceptToolStripSplitButton.Name = "acceptToolStripSplitButton"
            Me.acceptToolStripSplitButton.Size = New System.Drawing.Size(56, 0)
            Me.acceptToolStripSplitButton.Text = "Accept"
            Me.acceptToolStripSplitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo179.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo179.Header.Text = "Accept"
            Me.superToolTip1.SetToolTip(Me.acceptToolStripSplitButton, ToolTipInfo179)
            '
            'acceptAndMoveToNextToolStripMenuItem
            '
            Me.acceptAndMoveToNextToolStripMenuItem.Name = "acceptAndMoveToNextToolStripMenuItem"
            Me.acceptAndMoveToNextToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
            Me.acceptAndMoveToNextToolStripMenuItem.Text = "Accept and &Move to Next"
            '
            'acceptChangeToolStripMenuItem
            '
            Me.acceptChangeToolStripMenuItem.Enabled = False
            Me.acceptChangeToolStripMenuItem.Name = "acceptChangeToolStripMenuItem"
            Me.acceptChangeToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
            Me.acceptChangeToolStripMenuItem.Text = "A&ccept Change"
            '
            'acceptAllChangesShownToolStripMenuItem
            '
            Me.acceptAllChangesShownToolStripMenuItem.Enabled = False
            Me.acceptAllChangesShownToolStripMenuItem.Name = "acceptAllChangesShownToolStripMenuItem"
            Me.acceptAllChangesShownToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
            Me.acceptAllChangesShownToolStripMenuItem.Text = "&Accept All Changes Shown"
            '
            'acceptAllChangesInDocumentToolStripMenuItem
            '
            Me.acceptAllChangesInDocumentToolStripMenuItem.Name = "acceptAllChangesInDocumentToolStripMenuItem"
            Me.acceptAllChangesInDocumentToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
            Me.acceptAllChangesInDocumentToolStripMenuItem.Text = "Accept All Changes in &Document"
            '
            'toolStripPanelItem39
            '
            Me.toolStripPanelItem39.CausesValidation = False
            Me.toolStripPanelItem39.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem39.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rejectToolStripSplitButton, Me.prevToolStripBtn, Me.nextToolStripBtn})
            Me.toolStripPanelItem39.Name = "toolStripPanelItem39"
            Me.toolStripPanelItem39.Size = New System.Drawing.Size(74, 0)
            Me.toolStripPanelItem39.Text = "toolStripPanelItem39"
            Me.toolStripPanelItem39.Transparent = True
            '
            'rejectToolStripSplitButton
            '
            Me.rejectToolStripSplitButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rEjectAndMoveToNextToolStripMenuItem, Me.rejectChangeToolStripMenuItem, Me.rejectAllChangesShownToolStripMenuItem, Me.rejectAllChangesInDocumentToolStripMenuItem})
            Me.rejectToolStripSplitButton.Image = CType(resources.GetObject("rejectToolStripSplitButton.Image"), System.Drawing.Image)
            Me.rejectToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.rejectToolStripSplitButton.Name = "rejectToolStripSplitButton"
            Me.rejectToolStripSplitButton.Size = New System.Drawing.Size(70, 20)
            Me.rejectToolStripSplitButton.Text = "Reject"
            ToolTipInfo180.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo180.Header.Text = "Reject"
            Me.superToolTip1.SetToolTip(Me.rejectToolStripSplitButton, ToolTipInfo180)
            '
            'rEjectAndMoveToNextToolStripMenuItem
            '
            Me.rEjectAndMoveToNextToolStripMenuItem.Name = "rEjectAndMoveToNextToolStripMenuItem"
            Me.rEjectAndMoveToNextToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
            Me.rEjectAndMoveToNextToolStripMenuItem.Text = "Reject and &Move to Next"
            '
            'rejectChangeToolStripMenuItem
            '
            Me.rejectChangeToolStripMenuItem.Enabled = False
            Me.rejectChangeToolStripMenuItem.Name = "rejectChangeToolStripMenuItem"
            Me.rejectChangeToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
            Me.rejectChangeToolStripMenuItem.Text = "&Reject Change"
            '
            'rejectAllChangesShownToolStripMenuItem
            '
            Me.rejectAllChangesShownToolStripMenuItem.Name = "rejectAllChangesShownToolStripMenuItem"
            Me.rejectAllChangesShownToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
            Me.rejectAllChangesShownToolStripMenuItem.Text = "Reject &All Changes Shown"
            '
            'rejectAllChangesInDocumentToolStripMenuItem
            '
            Me.rejectAllChangesInDocumentToolStripMenuItem.Name = "rejectAllChangesInDocumentToolStripMenuItem"
            Me.rejectAllChangesInDocumentToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
            Me.rejectAllChangesInDocumentToolStripMenuItem.Text = "Reject All Changes in &Document"
            '
            'prevToolStripBtn
            '
            Me.prevToolStripBtn.Image = CType(resources.GetObject("prevToolStripBtn.Image"), System.Drawing.Image)
            Me.prevToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.prevToolStripBtn.Name = "prevToolStripBtn"
            Me.prevToolStripBtn.Size = New System.Drawing.Size(68, 20)
            Me.prevToolStripBtn.Text = "Previous"
            ToolTipInfo181.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo181.Header.Text = "Previous"
            Me.superToolTip1.SetToolTip(Me.prevToolStripBtn, ToolTipInfo181)
            '
            'nextToolStripBtn
            '
            Me.nextToolStripBtn.Image = CType(resources.GetObject("nextToolStripBtn.Image"), System.Drawing.Image)
            Me.nextToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.nextToolStripBtn.Name = "nextToolStripBtn"
            Me.nextToolStripBtn.Size = New System.Drawing.Size(50, 20)
            Me.nextToolStripBtn.Text = "Next"
            ToolTipInfo182.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo182.Header.Text = "Next"
            Me.superToolTip1.SetToolTip(Me.nextToolStripBtn, ToolTipInfo182)
            '
            'compareToolStripExt
            '
            Me.compareToolStripExt.CollapsedDropDownButtonText = "Compare"
            Me.compareToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.Right
            Me.compareToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.compareToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.compareToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.compareToolStripExt.Image = CType(resources.GetObject("compareToolStripExt.Image"), System.Drawing.Image)
            Me.compareToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.compareToolStripDropDownBtn, Me.shSrcDocToolStripDropDownBtn})
            Me.compareToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.compareToolStripExt.Location = New System.Drawing.Point(804, 1)
            Me.compareToolStripExt.Name = "compareToolStripExt"
            Me.compareToolStripExt.ShowLauncher = False
            Me.compareToolStripExt.Size = New System.Drawing.Size(112, 0)
            Me.compareToolStripExt.TabIndex = 4
            Me.compareToolStripExt.Text = "Compare"
            '
            'compareToolStripDropDownBtn
            '
            Me.compareToolStripDropDownBtn.Image = CType(resources.GetObject("compareToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.compareToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.compareToolStripDropDownBtn.Name = "compareToolStripDropDownBtn"
            Me.compareToolStripDropDownBtn.ShowDropDownArrow = False
            Me.compareToolStripDropDownBtn.Size = New System.Drawing.Size(70, 20)
            Me.compareToolStripDropDownBtn.Text = "Compare"
            ToolTipInfo183.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo183.Header.Text = "Compare"
            Me.superToolTip1.SetToolTip(Me.compareToolStripDropDownBtn, ToolTipInfo183)
            '
            'shSrcDocToolStripDropDownBtn
            '
            Me.shSrcDocToolStripDropDownBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.hideSourceDocumentsToolStripMenuItem, Me.showOriginalToolStripMenuItem, Me.showRevisedToolStripMenuItem, Me.showBothToolStripMenuItem})
            Me.shSrcDocToolStripDropDownBtn.Enabled = False
            Me.shSrcDocToolStripDropDownBtn.Image = CType(resources.GetObject("shSrcDocToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.shSrcDocToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.shSrcDocToolStripDropDownBtn.Name = "shSrcDocToolStripDropDownBtn"
            Me.shSrcDocToolStripDropDownBtn.Size = New System.Drawing.Size(98, 30)
            Me.shSrcDocToolStripDropDownBtn.Text = "Show Source" & Global.Microsoft.VisualBasic.ChrW(10) & "Documents"
            ToolTipInfo184.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo184.Header.Text = "Show Source Documents"
            Me.superToolTip1.SetToolTip(Me.shSrcDocToolStripDropDownBtn, ToolTipInfo184)
            '
            'hideSourceDocumentsToolStripMenuItem
            '
            Me.hideSourceDocumentsToolStripMenuItem.Name = "hideSourceDocumentsToolStripMenuItem"
            Me.hideSourceDocumentsToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
            Me.hideSourceDocumentsToolStripMenuItem.Text = "Hide Source Documents"
            '
            'showOriginalToolStripMenuItem
            '
            Me.showOriginalToolStripMenuItem.Name = "showOriginalToolStripMenuItem"
            Me.showOriginalToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
            Me.showOriginalToolStripMenuItem.Text = "Show Original"
            '
            'showRevisedToolStripMenuItem
            '
            Me.showRevisedToolStripMenuItem.Name = "showRevisedToolStripMenuItem"
            Me.showRevisedToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
            Me.showRevisedToolStripMenuItem.Text = "Show Revised"
            '
            'showBothToolStripMenuItem
            '
            Me.showBothToolStripMenuItem.Checked = True
            Me.showBothToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.showBothToolStripMenuItem.Name = "showBothToolStripMenuItem"
            Me.showBothToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
            Me.showBothToolStripMenuItem.Text = "Show Both"
            '
            'toolStripEx6
            '
            Me.toolStripEx6.CollapsedDropDownButtonText = "Protect"
            Me.toolStripEx6.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.toolStripEx6.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripEx6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx6.Image = CType(resources.GetObject("toolStripEx6.Image"), System.Drawing.Image)
            Me.toolStripEx6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.protectDocToolStripDropDownBtn})
            Me.toolStripEx6.Location = New System.Drawing.Point(916, 1)
            Me.toolStripEx6.Name = "toolStripEx6"
            Me.toolStripEx6.ShowLauncher = False
            Me.toolStripEx6.Size = New System.Drawing.Size(73, 0)
            Me.toolStripEx6.TabIndex = 5
            Me.toolStripEx6.Text = "Protect"
            '
            'protectDocToolStripDropDownBtn
            '
            Me.protectDocToolStripDropDownBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.restrictFormattingAndEditingToolStripMenuItem, Me.unrestrictedAccessToolStripMenuItem, Me.restrictedAccessToolStripMenuItem, Me.toolStripSeparator26, Me.manageCredentionalsToolStripMenuItem})
            Me.protectDocToolStripDropDownBtn.Image = CType(resources.GetObject("protectDocToolStripDropDownBtn.Image"), System.Drawing.Image)
            Me.protectDocToolStripDropDownBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.protectDocToolStripDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.protectDocToolStripDropDownBtn.Name = "protectDocToolStripDropDownBtn"
            Me.protectDocToolStripDropDownBtn.Size = New System.Drawing.Size(68, 0)
            Me.protectDocToolStripDropDownBtn.Text = "Protect" & Global.Microsoft.VisualBasic.ChrW(10) & "Document"
            Me.protectDocToolStripDropDownBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo185.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo185.Header.Text = "Protect Document"
            Me.superToolTip1.SetToolTip(Me.protectDocToolStripDropDownBtn, ToolTipInfo185)
            '
            'restrictFormattingAndEditingToolStripMenuItem
            '
            Me.restrictFormattingAndEditingToolStripMenuItem.Name = "restrictFormattingAndEditingToolStripMenuItem"
            Me.restrictFormattingAndEditingToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
            Me.restrictFormattingAndEditingToolStripMenuItem.Text = "Restrict &Formatting and Editing"
            '
            'unrestrictedAccessToolStripMenuItem
            '
            Me.unrestrictedAccessToolStripMenuItem.Checked = True
            Me.unrestrictedAccessToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.unrestrictedAccessToolStripMenuItem.Name = "unrestrictedAccessToolStripMenuItem"
            Me.unrestrictedAccessToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
            Me.unrestrictedAccessToolStripMenuItem.Text = "&Unrestricted Access"
            '
            'restrictedAccessToolStripMenuItem
            '
            Me.restrictedAccessToolStripMenuItem.Name = "restrictedAccessToolStripMenuItem"
            Me.restrictedAccessToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
            Me.restrictedAccessToolStripMenuItem.Text = "&Restricted Access"
            '
            'toolStripSeparator26
            '
            Me.toolStripSeparator26.Name = "toolStripSeparator26"
            Me.toolStripSeparator26.Size = New System.Drawing.Size(230, 6)
            '
            'manageCredentionalsToolStripMenuItem
            '
            Me.manageCredentionalsToolStripMenuItem.Name = "manageCredentionalsToolStripMenuItem"
            Me.manageCredentionalsToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
            Me.manageCredentionalsToolStripMenuItem.Text = "&Manage Credentials"
            '
            'viewTabItem
            '
            Me.superAccelerator.SetAccelerator(Me.viewTabItem, "W")
            Me.viewTabItem.ForeColor = System.Drawing.Color.MidnightBlue
            Me.viewTabItem.Name = "viewTabItem"
            Me.viewTabItem.Padding = New System.Windows.Forms.Padding(15, 2, 3, 5)
            '
            'ribbonControlAdv1.RibbonPanel7
            '
            Me.viewTabItem.Panel.Controls.Add(Me.docViewsToolStripExt)
            Me.viewTabItem.Panel.Controls.Add(Me.showToolStripExt)
            Me.viewTabItem.Panel.Controls.Add(Me.zoomToolStripExt)
            Me.viewTabItem.Panel.Controls.Add(Me.windowToolStripExt)
            Me.viewTabItem.Panel.Controls.Add(Me.macrosToolStripEx)
            Me.viewTabItem.Panel.Name = "RibbonPanel7"
            Me.viewTabItem.Panel.ScrollPosition = 0
            Me.viewTabItem.Panel.TabIndex = 7
            Me.viewTabItem.Panel.Text = "View"
            Me.viewTabItem.Size = New System.Drawing.Size(51, 24)
            Me.viewTabItem.Text = "View"
            '
            'docViewsToolStripExt
            '
            Me.docViewsToolStripExt.CollapsedDropDownButtonText = "Views"
            Me.docViewsToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.docViewsToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.docViewsToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.docViewsToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.docViewsToolStripExt.Image = CType(resources.GetObject("docViewsToolStripExt.Image"), System.Drawing.Image)
            Me.docViewsToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.printLayoutToolStripBtn, Me.fullScrToolStripBtn, Me.toolStripPanelItem46})
            Me.docViewsToolStripExt.Location = New System.Drawing.Point(0, 1)
            Me.docViewsToolStripExt.Name = "docViewsToolStripExt"
            Me.docViewsToolStripExt.ShowLauncher = False
            Me.docViewsToolStripExt.Size = New System.Drawing.Size(203, 0)
            Me.docViewsToolStripExt.TabIndex = 0
            Me.docViewsToolStripExt.Text = "Document Views"
            '
            'printLayoutToolStripBtn
            '
            Me.printLayoutToolStripBtn.Image = CType(resources.GetObject("printLayoutToolStripBtn.Image"), System.Drawing.Image)
            Me.printLayoutToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.printLayoutToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.printLayoutToolStripBtn.Name = "printLayoutToolStripBtn"
            Me.printLayoutToolStripBtn.Size = New System.Drawing.Size(44, 0)
            Me.printLayoutToolStripBtn.Text = "Print" & Global.Microsoft.VisualBasic.ChrW(10) & "Layout"
            Me.printLayoutToolStripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo186.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo186.Header.Text = "Print Layout"
            Me.superToolTip1.SetToolTip(Me.printLayoutToolStripBtn, ToolTipInfo186)
            '
            'fullScrToolStripBtn
            '
            Me.fullScrToolStripBtn.Image = CType(resources.GetObject("fullScrToolStripBtn.Image"), System.Drawing.Image)
            Me.fullScrToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.fullScrToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.fullScrToolStripBtn.Name = "fullScrToolStripBtn"
            Me.fullScrToolStripBtn.Size = New System.Drawing.Size(63, 0)
            Me.fullScrToolStripBtn.Text = "Full Screen" & Global.Microsoft.VisualBasic.ChrW(10) & "Reading"
            Me.fullScrToolStripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo187.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo187.Header.Text = "Full Screen Reading"
            Me.superToolTip1.SetToolTip(Me.fullScrToolStripBtn, ToolTipInfo187)
            '
            'toolStripPanelItem46
            '
            Me.toolStripPanelItem46.CausesValidation = False
            Me.toolStripPanelItem46.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem46.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.webLayoutToolStripBtn, Me.outlineToolStripBtn, Me.draftToolStripBtn})
            Me.toolStripPanelItem46.Name = "toolStripPanelItem46"
            Me.toolStripPanelItem46.Size = New System.Drawing.Size(89, 0)
            Me.toolStripPanelItem46.Text = "toolStripPanelItem46"
            Me.toolStripPanelItem46.Transparent = True
            '
            'webLayoutToolStripBtn
            '
            Me.webLayoutToolStripBtn.Image = CType(resources.GetObject("webLayoutToolStripBtn.Image"), System.Drawing.Image)
            Me.webLayoutToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.webLayoutToolStripBtn.Name = "webLayoutToolStripBtn"
            Me.webLayoutToolStripBtn.Size = New System.Drawing.Size(85, 20)
            Me.webLayoutToolStripBtn.Text = "Web Layout"
            ToolTipInfo188.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo188.Header.Text = "Web Layout"
            Me.superToolTip1.SetToolTip(Me.webLayoutToolStripBtn, ToolTipInfo188)
            '
            'outlineToolStripBtn
            '
            Me.outlineToolStripBtn.Image = CType(resources.GetObject("outlineToolStripBtn.Image"), System.Drawing.Image)
            Me.outlineToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.outlineToolStripBtn.Name = "outlineToolStripBtn"
            Me.outlineToolStripBtn.Size = New System.Drawing.Size(61, 20)
            Me.outlineToolStripBtn.Text = "Outline"
            ToolTipInfo189.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo189.Header.Text = "Outline"
            Me.superToolTip1.SetToolTip(Me.outlineToolStripBtn, ToolTipInfo189)
            '
            'draftToolStripBtn
            '
            Me.draftToolStripBtn.Image = CType(resources.GetObject("draftToolStripBtn.Image"), System.Drawing.Image)
            Me.draftToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.draftToolStripBtn.Name = "draftToolStripBtn"
            Me.draftToolStripBtn.Size = New System.Drawing.Size(52, 20)
            Me.draftToolStripBtn.Text = "Draft"
            ToolTipInfo190.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo190.Header.Text = "Draft"
            Me.superToolTip1.SetToolTip(Me.draftToolStripBtn, ToolTipInfo190)
            '
            'showToolStripExt
            '
            Me.showToolStripExt.CollapsedDropDownButtonText = "Visibility"
            Me.showToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.showToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.showToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.showToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.showToolStripExt.Image = CType(resources.GetObject("showToolStripExt.Image"), System.Drawing.Image)
            Me.showToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem40, Me.toolStripPanelItem41})
            Me.showToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
            Me.showToolStripExt.Location = New System.Drawing.Point(203, 1)
            Me.showToolStripExt.Name = "showToolStripExt"
            Me.showToolStripExt.ShowLauncher = False
            Me.showToolStripExt.Size = New System.Drawing.Size(204, 0)
            Me.showToolStripExt.TabIndex = 1
            Me.showToolStripExt.Text = "Show/Hide"
            '
            'toolStripPanelItem40
            '
            Me.toolStripPanelItem40.CausesValidation = False
            Me.toolStripPanelItem40.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem40.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rulerCheckBox, Me.gridlinesCheckBox2, Me.msgBarCheckBox})
            Me.toolStripPanelItem40.Name = "toolStripPanelItem40"
            Me.toolStripPanelItem40.Size = New System.Drawing.Size(91, 0)
            Me.toolStripPanelItem40.Text = "toolStripPanelItem40"
            Me.toolStripPanelItem40.Transparent = True
            '
            'rulerCheckBox
            '
            Me.rulerCheckBox.Name = "rulerCheckBox"
            Me.rulerCheckBox.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
            Me.rulerCheckBox.Size = New System.Drawing.Size(51, 21)
            Me.rulerCheckBox.Text = "Ruler"
            '
            'gridlinesCheckBox2
            '
            Me.gridlinesCheckBox2.Name = "gridlinesCheckBox2"
            Me.gridlinesCheckBox2.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
            Me.gridlinesCheckBox2.Size = New System.Drawing.Size(66, 21)
            Me.gridlinesCheckBox2.Text = "Gridlines"
            '
            'msgBarCheckBox
            '
            Me.msgBarCheckBox.Name = "msgBarCheckBox"
            Me.msgBarCheckBox.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
            Me.msgBarCheckBox.Size = New System.Drawing.Size(87, 21)
            Me.msgBarCheckBox.Text = "Message Bar"
            '
            'toolStripPanelItem41
            '
            Me.toolStripPanelItem41.CausesValidation = False
            Me.toolStripPanelItem41.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem41.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.docMapCheckBox, Me.thumbNailsCheckBox})
            Me.toolStripPanelItem41.Name = "toolStripPanelItem41"
            Me.toolStripPanelItem41.Size = New System.Drawing.Size(101, 0)
            Me.toolStripPanelItem41.Text = "toolStripPanelItem41"
            Me.toolStripPanelItem41.Transparent = True
            '
            'docMapCheckBox
            '
            Me.docMapCheckBox.Name = "docMapCheckBox"
            Me.docMapCheckBox.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
            Me.docMapCheckBox.Size = New System.Drawing.Size(97, 21)
            Me.docMapCheckBox.Text = "Document Map"
            '
            'thumbNailsCheckBox
            '
            Me.thumbNailsCheckBox.Name = "thumbNailsCheckBox"
            Me.thumbNailsCheckBox.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
            Me.thumbNailsCheckBox.Size = New System.Drawing.Size(79, 21)
            Me.thumbNailsCheckBox.Text = "Thumbnails"
            '
            'zoomToolStripExt
            '
            Me.zoomToolStripExt.CollapsedDropDownButtonText = "Zoom"
            Me.zoomToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.zoomToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.zoomToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.zoomToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.zoomToolStripExt.Image = CType(resources.GetObject("zoomToolStripExt.Image"), System.Drawing.Image)
            Me.zoomToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.zoomToolStripBtn, Me.toolStripPanelItem42})
            Me.zoomToolStripExt.Location = New System.Drawing.Point(407, 1)
            Me.zoomToolStripExt.Name = "zoomToolStripExt"
            Me.zoomToolStripExt.ShowLauncher = False
            Me.zoomToolStripExt.Size = New System.Drawing.Size(130, 0)
            Me.zoomToolStripExt.TabIndex = 2
            Me.zoomToolStripExt.Text = "Zoom"
            '
            'zoomToolStripBtn
            '
            Me.zoomToolStripBtn.Image = CType(resources.GetObject("zoomToolStripBtn.Image"), System.Drawing.Image)
            Me.zoomToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.zoomToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.zoomToolStripBtn.Name = "zoomToolStripBtn"
            Me.zoomToolStripBtn.Size = New System.Drawing.Size(37, 0)
            Me.zoomToolStripBtn.Text = "Zoom"
            Me.zoomToolStripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo191.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo191.Header.Text = "Zoom"
            Me.superToolTip1.SetToolTip(Me.zoomToolStripBtn, ToolTipInfo191)
            '
            'toolStripPanelItem42
            '
            Me.toolStripPanelItem42.CausesValidation = False
            Me.toolStripPanelItem42.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem42.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.onePgToolStripBtn, Me.twoPgsToolStripBtn, Me.pgWidthToolStripBtn})
            Me.toolStripPanelItem42.Name = "toolStripPanelItem42"
            Me.toolStripPanelItem42.Size = New System.Drawing.Size(86, 0)
            Me.toolStripPanelItem42.Text = "toolStripPanelItem42"
            Me.toolStripPanelItem42.Transparent = True
            '
            'onePgToolStripBtn
            '
            Me.onePgToolStripBtn.Image = CType(resources.GetObject("onePgToolStripBtn.Image"), System.Drawing.Image)
            Me.onePgToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.onePgToolStripBtn.Name = "onePgToolStripBtn"
            Me.onePgToolStripBtn.Size = New System.Drawing.Size(74, 20)
            Me.onePgToolStripBtn.Text = "One Page"
            ToolTipInfo192.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo192.Header.Text = "One Page"
            Me.superToolTip1.SetToolTip(Me.onePgToolStripBtn, ToolTipInfo192)
            '
            'twoPgsToolStripBtn
            '
            Me.twoPgsToolStripBtn.Image = CType(resources.GetObject("twoPgsToolStripBtn.Image"), System.Drawing.Image)
            Me.twoPgsToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.twoPgsToolStripBtn.Name = "twoPgsToolStripBtn"
            Me.twoPgsToolStripBtn.Size = New System.Drawing.Size(79, 20)
            Me.twoPgsToolStripBtn.Text = "Two Pages"
            ToolTipInfo193.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo193.Header.Text = "Two Pages"
            Me.superToolTip1.SetToolTip(Me.twoPgsToolStripBtn, ToolTipInfo193)
            '
            'pgWidthToolStripBtn
            '
            Me.pgWidthToolStripBtn.Image = CType(resources.GetObject("pgWidthToolStripBtn.Image"), System.Drawing.Image)
            Me.pgWidthToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.pgWidthToolStripBtn.Name = "pgWidthToolStripBtn"
            Me.pgWidthToolStripBtn.Size = New System.Drawing.Size(82, 20)
            Me.pgWidthToolStripBtn.Text = "Page Width"
            ToolTipInfo194.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo194.Header.Text = "Page Width"
            Me.superToolTip1.SetToolTip(Me.pgWidthToolStripBtn, ToolTipInfo194)
            '
            'windowToolStripExt
            '
            Me.windowToolStripExt.CollapsedDropDownButtonText = "Windows"
            Me.windowToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.windowToolStripExt.Dock = System.Windows.Forms.DockStyle.None
            Me.windowToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
            Me.windowToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.windowToolStripExt.Image = CType(resources.GetObject("windowToolStripExt.Image"), System.Drawing.Image)
            Me.windowToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem45, Me.toolStripSeparator23, Me.toolStripPanelItem43, Me.toolStripSeparator24, Me.switchWindowsToolStripDropDwnBtn})
            Me.windowToolStripExt.Location = New System.Drawing.Point(537, 1)
            Me.windowToolStripExt.Name = "windowToolStripExt"
            Me.windowToolStripExt.ShowLauncher = False
            Me.windowToolStripExt.Size = New System.Drawing.Size(333, 0)
            Me.windowToolStripExt.TabIndex = 3
            Me.windowToolStripExt.Text = "Window"
            '
            'toolStripPanelItem45
            '
            Me.toolStripPanelItem45.CausesValidation = False
            Me.toolStripPanelItem45.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem45.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nwWindowToolStripBtn, Me.arrangeAllToolStripBtn, Me.splitToolStripBtn})
            Me.toolStripPanelItem45.Name = "toolStripPanelItem45"
            Me.toolStripPanelItem45.Size = New System.Drawing.Size(93, 0)
            Me.toolStripPanelItem45.Text = "toolStripPanelItem45"
            Me.toolStripPanelItem45.Transparent = True
            '
            'nwWindowToolStripBtn
            '
            Me.nwWindowToolStripBtn.Image = CType(resources.GetObject("nwWindowToolStripBtn.Image"), System.Drawing.Image)
            Me.nwWindowToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.nwWindowToolStripBtn.Name = "nwWindowToolStripBtn"
            Me.nwWindowToolStripBtn.Size = New System.Drawing.Size(89, 20)
            Me.nwWindowToolStripBtn.Text = "New Window"
            ToolTipInfo195.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo195.Header.Text = "New Window"
            Me.superToolTip1.SetToolTip(Me.nwWindowToolStripBtn, ToolTipInfo195)
            '
            'arrangeAllToolStripBtn
            '
            Me.arrangeAllToolStripBtn.Image = CType(resources.GetObject("arrangeAllToolStripBtn.Image"), System.Drawing.Image)
            Me.arrangeAllToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.arrangeAllToolStripBtn.Name = "arrangeAllToolStripBtn"
            Me.arrangeAllToolStripBtn.Size = New System.Drawing.Size(80, 20)
            Me.arrangeAllToolStripBtn.Text = "Arrange All"
            ToolTipInfo196.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo196.Header.Text = "Arrange All"
            Me.superToolTip1.SetToolTip(Me.arrangeAllToolStripBtn, ToolTipInfo196)
            '
            'splitToolStripBtn
            '
            Me.splitToolStripBtn.Image = CType(resources.GetObject("splitToolStripBtn.Image"), System.Drawing.Image)
            Me.splitToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.splitToolStripBtn.Name = "splitToolStripBtn"
            Me.splitToolStripBtn.Size = New System.Drawing.Size(47, 20)
            Me.splitToolStripBtn.Text = "Split"
            ToolTipInfo197.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo197.Header.Text = "Split"
            Me.superToolTip1.SetToolTip(Me.splitToolStripBtn, ToolTipInfo197)
            '
            'toolStripSeparator23
            '
            Me.toolStripSeparator23.Name = "toolStripSeparator23"
            Me.toolStripSeparator23.Size = New System.Drawing.Size(6, 0)
            '
            'toolStripPanelItem43
            '
            Me.toolStripPanelItem43.CausesValidation = False
            Me.toolStripPanelItem43.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem43.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.viewToolStripBtn, Me.syncScrollToolStripBtn, Me.resetWindowPosToolStripBtn})
            Me.toolStripPanelItem43.Name = "toolStripPanelItem43"
            Me.toolStripPanelItem43.Size = New System.Drawing.Size(140, 0)
            Me.toolStripPanelItem43.Text = "toolStripPanelItem43"
            Me.toolStripPanelItem43.Transparent = True
            '
            'viewToolStripBtn
            '
            Me.viewToolStripBtn.Image = CType(resources.GetObject("viewToolStripBtn.Image"), System.Drawing.Image)
            Me.viewToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.viewToolStripBtn.Name = "viewToolStripBtn"
            Me.viewToolStripBtn.Size = New System.Drawing.Size(110, 20)
            Me.viewToolStripBtn.Text = "View Side by Side"
            ToolTipInfo198.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo198.Header.Text = "View Side by Side"
            Me.superToolTip1.SetToolTip(Me.viewToolStripBtn, ToolTipInfo198)
            '
            'syncScrollToolStripBtn
            '
            Me.syncScrollToolStripBtn.Image = CType(resources.GetObject("syncScrollToolStripBtn.Image"), System.Drawing.Image)
            Me.syncScrollToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.syncScrollToolStripBtn.Name = "syncScrollToolStripBtn"
            Me.syncScrollToolStripBtn.Size = New System.Drawing.Size(131, 20)
            Me.syncScrollToolStripBtn.Text = "Synchronous Scrolling"
            ToolTipInfo199.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo199.Header.Text = "Synchronous Scrolling"
            Me.superToolTip1.SetToolTip(Me.syncScrollToolStripBtn, ToolTipInfo199)
            '
            'resetWindowPosToolStripBtn
            '
            Me.resetWindowPosToolStripBtn.Image = CType(resources.GetObject("resetWindowPosToolStripBtn.Image"), System.Drawing.Image)
            Me.resetWindowPosToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.resetWindowPosToolStripBtn.Name = "resetWindowPosToolStripBtn"
            Me.resetWindowPosToolStripBtn.Size = New System.Drawing.Size(136, 20)
            Me.resetWindowPosToolStripBtn.Text = "Reset Window Position"
            ToolTipInfo200.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo200.Header.Text = "Reset Window Position"
            Me.superToolTip1.SetToolTip(Me.resetWindowPosToolStripBtn, ToolTipInfo200)
            '
            'toolStripSeparator24
            '
            Me.toolStripSeparator24.Name = "toolStripSeparator24"
            Me.toolStripSeparator24.Size = New System.Drawing.Size(6, 0)
            '
            'switchWindowsToolStripDropDwnBtn
            '
            Me.switchWindowsToolStripDropDwnBtn.Image = CType(resources.GetObject("switchWindowsToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.switchWindowsToolStripDropDwnBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.switchWindowsToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.switchWindowsToolStripDropDwnBtn.Name = "switchWindowsToolStripDropDwnBtn"
            Me.switchWindowsToolStripDropDwnBtn.Size = New System.Drawing.Size(63, 0)
            Me.switchWindowsToolStripDropDwnBtn.Text = "Switch" & Global.Microsoft.VisualBasic.ChrW(10) & "Windows"
            Me.switchWindowsToolStripDropDwnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo201.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo201.Header.Text = "Switch Windows"
            Me.superToolTip1.SetToolTip(Me.switchWindowsToolStripDropDwnBtn, ToolTipInfo201)
            '
            'macrosToolStripEx
            '
            Me.macrosToolStripEx.CollapsedDropDownButtonText = "Macros"
            Me.macrosToolStripEx.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
            Me.macrosToolStripEx.Dock = System.Windows.Forms.DockStyle.None
            Me.macrosToolStripEx.ForeColor = System.Drawing.Color.MidnightBlue
            Me.macrosToolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.macrosToolStripEx.Image = CType(resources.GetObject("macrosToolStripEx.Image"), System.Drawing.Image)
            Me.macrosToolStripEx.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.macrosToolStripDropDwnBtn})
            Me.macrosToolStripEx.Location = New System.Drawing.Point(870, 1)
            Me.macrosToolStripEx.Name = "macrosToolStripEx"
            Me.macrosToolStripEx.ShowLauncher = False
            Me.macrosToolStripEx.Size = New System.Drawing.Size(59, 0)
            Me.macrosToolStripEx.TabIndex = 4
            Me.macrosToolStripEx.Text = "Macros"
            '
            'macrosToolStripDropDwnBtn
            '
            Me.macrosToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.viewMacrosToolStripMenuItem, Me.reToolStripMenuItem, Me.pauseMacroToolStripMenuItem})
            Me.macrosToolStripDropDwnBtn.Image = CType(resources.GetObject("macrosToolStripDropDwnBtn.Image"), System.Drawing.Image)
            Me.macrosToolStripDropDwnBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.macrosToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.macrosToolStripDropDwnBtn.Name = "macrosToolStripDropDwnBtn"
            Me.macrosToolStripDropDwnBtn.Size = New System.Drawing.Size(54, 0)
            Me.macrosToolStripDropDwnBtn.Text = "Macros"
            Me.macrosToolStripDropDwnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ToolTipInfo202.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo202.Header.Text = "Macros"
            Me.superToolTip1.SetToolTip(Me.macrosToolStripDropDwnBtn, ToolTipInfo202)
            '
            'viewMacrosToolStripMenuItem
            '
            Me.viewMacrosToolStripMenuItem.Name = "viewMacrosToolStripMenuItem"
            Me.viewMacrosToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
            Me.viewMacrosToolStripMenuItem.Text = "&View Macros"
            '
            'reToolStripMenuItem
            '
            Me.reToolStripMenuItem.Name = "reToolStripMenuItem"
            Me.reToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
            Me.reToolStripMenuItem.Text = "&Record Macro..."
            '
            'pauseMacroToolStripMenuItem
            '
            Me.pauseMacroToolStripMenuItem.Enabled = False
            Me.pauseMacroToolStripMenuItem.Name = "pauseMacroToolStripMenuItem"
            Me.pauseMacroToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
            Me.pauseMacroToolStripMenuItem.Text = "&Pause Recording"
            '
            'toolStripButton7
            '
            Me.toolStripButton7.AutoSize = False
            Me.toolStripButton7.AutoToolTip = False
            Me.toolStripButton7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolStripButton7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton7.Name = "toolStripButton7"
            Me.toolStripButton7.Size = New System.Drawing.Size(265, 22)
            Me.toolStripButton7.Text = "&1 Document.doc"
            Me.toolStripButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo7.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo7.Header.Text = "Document.doc"
            Me.superToolTip1.SetToolTip(Me.toolStripButton7, ToolTipInfo7)
            '
            'toolStripButton8
            '
            Me.toolStripButton8.AutoSize = False
            Me.toolStripButton8.AutoToolTip = False
            Me.toolStripButton8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton8.Name = "toolStripButton8"
            Me.toolStripButton8.Size = New System.Drawing.Size(265, 22)
            Me.toolStripButton8.Text = "&2 New Features.doc"
            Me.toolStripButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo8.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo8.Header.Text = "New Features.doc"
            Me.superToolTip1.SetToolTip(Me.toolStripButton8, ToolTipInfo8)
            '
            'toolStripButton9
            '
            Me.toolStripButton9.AutoSize = False
            Me.toolStripButton9.AutoToolTip = False
            Me.toolStripButton9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton9.Name = "toolStripButton9"
            Me.toolStripButton9.Size = New System.Drawing.Size(265, 22)
            Me.toolStripButton9.Text = "&3 Report.doc"
            Me.toolStripButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo9.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo9.Header.Text = "Report.doc"
            Me.superToolTip1.SetToolTip(Me.toolStripButton9, ToolTipInfo9)
            '
            'toolStripButton1
            '
            Me.toolStripButton1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolStripButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripButton1.Image = Global.Word2007Demo_2005.My.Resources.Resources.new_icon
            Me.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton1.Name = "toolStripButton1"
            Me.toolStripButton1.Padding = New System.Windows.Forms.Padding(4)
            Me.toolStripButton1.Size = New System.Drawing.Size(121, 44)
            Me.toolStripButton1.Text = "&New"
            ToolTipInfo10.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo10.Header.Text = "New"
            Me.superToolTip1.SetToolTip(Me.toolStripButton1, ToolTipInfo10)
            '
            'toolStripButton2
            '
            Me.toolStripButton2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripButton2.Image = Global.Word2007Demo_2005.My.Resources.Resources.open_icon
            Me.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton2.Name = "toolStripButton2"
            Me.toolStripButton2.Padding = New System.Windows.Forms.Padding(4)
            Me.toolStripButton2.Size = New System.Drawing.Size(121, 44)
            Me.toolStripButton2.Text = "&Open"
            ToolTipInfo11.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo11.Header.Text = "Open"
            Me.superToolTip1.SetToolTip(Me.toolStripButton2, ToolTipInfo11)
            '
            'toolStripSeparator27
            '
            Me.toolStripSeparator27.Name = "toolStripSeparator27"
            Me.toolStripSeparator27.Size = New System.Drawing.Size(105, 2)
            '
            'toolStripButton18
            '
            Me.toolStripButton18.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripButton18.Image = Global.Word2007Demo_2005.My.Resources.Resources.save_icon
            Me.toolStripButton18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton18.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton18.Name = "toolStripButton18"
            Me.toolStripButton18.Padding = New System.Windows.Forms.Padding(4)
            Me.toolStripButton18.Size = New System.Drawing.Size(121, 44)
            Me.toolStripButton18.Text = "&Save"
            ToolTipInfo12.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo12.Header.Text = "Save"
            Me.superToolTip1.SetToolTip(Me.toolStripButton18, ToolTipInfo12)
            '
            'officeSplitButton1
            '
            Me.officeSplitButton1.AutoSize = False
            Me.officeSplitButton1.DropDownButtonWidth = 18
            Me.officeSplitButton1.DropDownFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.officeSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.officeButton1, Me.officeButton2, Me.officeButton3, Me.officeButton4, Me.officeButton5})
            Me.officeSplitButton1.DropDownText = "Save a copy of the document"
            Me.officeSplitButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeSplitButton1.Image = CType(resources.GetObject("officeSplitButton1.Image"), System.Drawing.Image)
            Me.officeSplitButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeSplitButton1.Name = "officeSplitButton1"
            Me.officeSplitButton1.Padding = New System.Windows.Forms.Padding(4)
            Me.officeSplitButton1.Size = New System.Drawing.Size(121, 36)
            Me.officeSplitButton1.Text = "Save &As..."
            Me.officeSplitButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo18.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo18.Header.Text = "Save As"
            Me.superToolTip1.SetToolTip(Me.officeSplitButton1, ToolTipInfo18)
            '
            'officeButton1
            '
            Me.officeButton1.AutoSize = False
            Me.officeButton1.AutoToolTip = False
            Me.officeButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton1.HelpText = "Save the document in default file format."
            Me.officeButton1.Image = CType(resources.GetObject("officeButton1.Image"), System.Drawing.Image)
            Me.officeButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton1.Name = "officeButton1"
            Me.officeButton1.Size = New System.Drawing.Size(263, 36)
            Me.officeButton1.Text = "&Word Document"
            Me.officeButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo13.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo13.Header.Text = "Word Document"
            Me.superToolTip1.SetToolTip(Me.officeButton1, ToolTipInfo13)
            '
            'officeButton2
            '
            Me.officeButton2.AutoSize = False
            Me.officeButton2.AutoToolTip = False
            Me.officeButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton2.HelpText = "Save the document as a template that can " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "be used to format future documents."
            Me.officeButton2.Image = CType(resources.GetObject("officeButton2.Image"), System.Drawing.Image)
            Me.officeButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton2.Name = "officeButton2"
            Me.officeButton2.Size = New System.Drawing.Size(263, 45)
            Me.officeButton2.Text = "Word &Template"
            Me.officeButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo14.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo14.Header.Text = "Word Template"
            Me.superToolTip1.SetToolTip(Me.officeButton2, ToolTipInfo14)
            '
            'officeButton3
            '
            Me.officeButton3.AutoSize = False
            Me.officeButton3.AutoToolTip = False
            Me.officeButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton3.HelpText = "Save a copy of the document that is fully " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "compatible with Word 97-2003."
            Me.officeButton3.Image = CType(resources.GetObject("officeButton3.Image"), System.Drawing.Image)
            Me.officeButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton3.Name = "officeButton3"
            Me.officeButton3.Size = New System.Drawing.Size(263, 45)
            Me.officeButton3.Text = "Word &97-2003 Document"
            Me.officeButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo15.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo15.Header.Text = "Word 97-2003 Document"
            Me.superToolTip1.SetToolTip(Me.officeButton3, ToolTipInfo15)
            '
            'officeButton4
            '
            Me.officeButton4.AutoSize = False
            Me.officeButton4.AutoToolTip = False
            Me.officeButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton4.HelpText = "Learn about add-ins to save to other " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "formats such as PDF or XPS."
            Me.officeButton4.Image = CType(resources.GetObject("officeButton4.Image"), System.Drawing.Image)
            Me.officeButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton4.Name = "officeButton4"
            Me.officeButton4.Size = New System.Drawing.Size(263, 45)
            Me.officeButton4.Text = "&Find add-ins for other file formats"
            Me.officeButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo16.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo16.Header.Text = "Find add-ins for other file formats"
            Me.superToolTip1.SetToolTip(Me.officeButton4, ToolTipInfo16)
            '
            'officeButton5
            '
            Me.officeButton5.AutoSize = False
            Me.officeButton5.AutoToolTip = False
            Me.officeButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton5.HelpText = "Open the Save as dialog box to select from " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "all possible file types."
            Me.officeButton5.Image = CType(resources.GetObject("officeButton5.Image"), System.Drawing.Image)
            Me.officeButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton5.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton5.Name = "officeButton5"
            Me.officeButton5.Size = New System.Drawing.Size(263, 45)
            Me.officeButton5.Text = "&Other Formats"
            Me.officeButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo17.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo17.Header.Text = "Other Formats"
            Me.superToolTip1.SetToolTip(Me.officeButton5, ToolTipInfo17)
            '
            'toolStripSeparator28
            '
            Me.toolStripSeparator28.Name = "toolStripSeparator28"
            Me.toolStripSeparator28.Size = New System.Drawing.Size(105, 2)
            '
            'officeSplitButton2
            '
            Me.officeSplitButton2.DropDownButtonWidth = 18
            Me.officeSplitButton2.DropDownFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.officeSplitButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.officeButton6, Me.officeButton7, Me.officeButton8})
            Me.officeSplitButton2.DropDownText = "Preview and print the document"
            Me.officeSplitButton2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeSplitButton2.Image = Global.Word2007Demo_2005.My.Resources.Resources.printer_icon
            Me.officeSplitButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeSplitButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeSplitButton2.Name = "officeSplitButton2"
            Me.officeSplitButton2.Padding = New System.Windows.Forms.Padding(4)
            Me.officeSplitButton2.Size = New System.Drawing.Size(121, 36)
            Me.officeSplitButton2.Text = "&Print"
            Me.officeSplitButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo22.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo22.Header.Text = "Print"
            Me.superToolTip1.SetToolTip(Me.officeSplitButton2, ToolTipInfo22)
            '
            'officeButton6
            '
            Me.officeButton6.AutoToolTip = False
            Me.officeButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton6.HelpText = "Select a printer, number of copies and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "other printing options before printing."
            Me.officeButton6.Image = CType(resources.GetObject("officeButton6.Image"), System.Drawing.Image)
            Me.officeButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton6.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton6.Name = "officeButton6"
            Me.officeButton6.Size = New System.Drawing.Size(263, 45)
            Me.officeButton6.Text = "&Print"
            Me.officeButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo19.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo19.Header.Text = "Print"
            Me.superToolTip1.SetToolTip(Me.officeButton6, ToolTipInfo19)
            '
            'officeButton7
            '
            Me.officeButton7.AutoToolTip = False
            Me.officeButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton7.HelpText = "Send the document directly to the default " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "printer without making changes"
            Me.officeButton7.Image = CType(resources.GetObject("officeButton7.Image"), System.Drawing.Image)
            Me.officeButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton7.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton7.Name = "officeButton7"
            Me.officeButton7.Size = New System.Drawing.Size(263, 45)
            Me.officeButton7.Text = "&Quick Print"
            Me.officeButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo20.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo20.Header.Text = "Quick Print"
            Me.superToolTip1.SetToolTip(Me.officeButton7, ToolTipInfo20)
            '
            'officeButton8
            '
            Me.officeButton8.AutoToolTip = False
            Me.officeButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton8.HelpText = "Preview and make changes to pages before " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "printing."
            Me.officeButton8.Image = CType(resources.GetObject("officeButton8.Image"), System.Drawing.Image)
            Me.officeButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton8.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton8.Name = "officeButton8"
            Me.officeButton8.Size = New System.Drawing.Size(263, 45)
            Me.officeButton8.Text = "Print Pre&view"
            Me.officeButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo21.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo21.Header.Text = "Print Preview"
            Me.superToolTip1.SetToolTip(Me.officeButton8, ToolTipInfo21)
            '
            'officeDropDownButton1
            '
            Me.officeDropDownButton1.DropDownFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.officeDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.officeButton9, Me.officeButton10, Me.officeButton11, Me.officeButton12, Me.officeButton13, Me.officeButton14, Me.officeButton15})
            Me.officeDropDownButton1.DropDownText = "Prepare the document for distribution"
            Me.officeDropDownButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeDropDownButton1.Image = Global.Word2007Demo_2005.My.Resources.Resources.prepare_icon
            Me.officeDropDownButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeDropDownButton1.Name = "officeDropDownButton1"
            Me.officeDropDownButton1.Padding = New System.Windows.Forms.Padding(4)
            Me.officeDropDownButton1.Size = New System.Drawing.Size(121, 44)
            Me.officeDropDownButton1.Text = "Pr&epare"
            Me.officeDropDownButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo30.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo30.Header.Text = "Prepare"
            Me.superToolTip1.SetToolTip(Me.officeDropDownButton1, ToolTipInfo30)
            '
            'officeButton9
            '
            Me.officeButton9.AutoToolTip = False
            Me.officeButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton9.HelpText = "View and edit document properties, such " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "as Title Author and keywords."
            Me.officeButton9.Image = CType(resources.GetObject("officeButton9.Image"), System.Drawing.Image)
            Me.officeButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton9.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton9.Name = "officeButton9"
            Me.officeButton9.Size = New System.Drawing.Size(263, 45)
            Me.officeButton9.Text = "Properties"
            Me.officeButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo23.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo23.Header.Text = "Properties"
            Me.superToolTip1.SetToolTip(Me.officeButton9, ToolTipInfo23)
            '
            'officeButton10
            '
            Me.officeButton10.AutoToolTip = False
            Me.officeButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton10.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton10.HelpText = "Check the document for hidden metadate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or personal information."
            Me.officeButton10.Image = CType(resources.GetObject("officeButton10.Image"), System.Drawing.Image)
            Me.officeButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton10.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton10.Name = "officeButton10"
            Me.officeButton10.Size = New System.Drawing.Size(263, 45)
            Me.officeButton10.Text = "Inspect document"
            Me.officeButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo24.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo24.Header.Text = "Inspect document"
            Me.superToolTip1.SetToolTip(Me.officeButton10, ToolTipInfo24)
            '
            'officeButton11
            '
            Me.officeButton11.AutoToolTip = False
            Me.officeButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton11.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton11.HelpText = "Increase the security of the document by " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "adding encryption."
            Me.officeButton11.Image = CType(resources.GetObject("officeButton11.Image"), System.Drawing.Image)
            Me.officeButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton11.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton11.Name = "officeButton11"
            Me.officeButton11.Size = New System.Drawing.Size(263, 45)
            Me.officeButton11.Text = "Encrypt Document"
            Me.officeButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo25.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo25.Header.Text = "Encrypt Document"
            Me.superToolTip1.SetToolTip(Me.officeButton11, ToolTipInfo25)
            '
            'officeButton12
            '
            Me.officeButton12.AutoToolTip = False
            Me.officeButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton12.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton12.HelpText = "Grant people access while restricting their" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "adbility to edit, copy and print."
            Me.officeButton12.Image = CType(resources.GetObject("officeButton12.Image"), System.Drawing.Image)
            Me.officeButton12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton12.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton12.Name = "officeButton12"
            Me.officeButton12.Size = New System.Drawing.Size(263, 45)
            Me.officeButton12.Text = "Restrict Permission"
            Me.officeButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo26.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo26.Header.Text = "Restrict Permission"
            Me.superToolTip1.SetToolTip(Me.officeButton12, ToolTipInfo26)
            '
            'officeButton13
            '
            Me.officeButton13.AutoToolTip = False
            Me.officeButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton13.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton13.HelpText = "Ensure the integrity of the document by " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "adding an invisible digital signature."
            Me.officeButton13.Image = CType(resources.GetObject("officeButton13.Image"), System.Drawing.Image)
            Me.officeButton13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton13.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton13.Name = "officeButton13"
            Me.officeButton13.Size = New System.Drawing.Size(263, 45)
            Me.officeButton13.Text = "Add a Digital Signature"
            Me.officeButton13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo27.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo27.Header.Text = "Add a Digital Signature"
            Me.superToolTip1.SetToolTip(Me.officeButton13, ToolTipInfo27)
            '
            'officeButton14
            '
            Me.officeButton14.AutoToolTip = False
            Me.officeButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton14.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton14.HelpText = "Let readers know the document is final and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "make it read-only."
            Me.officeButton14.Image = CType(resources.GetObject("officeButton14.Image"), System.Drawing.Image)
            Me.officeButton14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton14.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton14.Name = "officeButton14"
            Me.officeButton14.Size = New System.Drawing.Size(263, 45)
            Me.officeButton14.Text = "Mark as Final"
            Me.officeButton14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo28.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo28.Header.Text = "Mark as Final"
            Me.superToolTip1.SetToolTip(Me.officeButton14, ToolTipInfo28)
            '
            'officeButton15
            '
            Me.officeButton15.AutoToolTip = False
            Me.officeButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton15.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton15.HelpText = "Check for features not supported by earlier " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "versions of Word."
            Me.officeButton15.Image = CType(resources.GetObject("officeButton15.Image"), System.Drawing.Image)
            Me.officeButton15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton15.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton15.Name = "officeButton15"
            Me.officeButton15.Size = New System.Drawing.Size(263, 45)
            Me.officeButton15.Text = "Run Compatibility Checker"
            Me.officeButton15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo29.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo29.Header.Text = "Run Compatibility Checker"
            Me.superToolTip1.SetToolTip(Me.officeButton15, ToolTipInfo29)
            '
            'officeDropDownButton3
            '
            Me.officeDropDownButton3.DropDownFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.officeDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.officeButton16, Me.officeButton17})
            Me.officeDropDownButton3.DropDownText = "Send a copy to other people"
            Me.officeDropDownButton3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeDropDownButton3.Image = CType(resources.GetObject("officeDropDownButton3.Image"), System.Drawing.Image)
            Me.officeDropDownButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeDropDownButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeDropDownButton3.Name = "officeDropDownButton3"
            Me.officeDropDownButton3.Padding = New System.Windows.Forms.Padding(4)
            Me.officeDropDownButton3.Size = New System.Drawing.Size(121, 44)
            Me.officeDropDownButton3.Text = "Sen&d"
            Me.officeDropDownButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo33.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo33.Header.Text = "Send"
            Me.superToolTip1.SetToolTip(Me.officeDropDownButton3, ToolTipInfo33)
            '
            'officeButton16
            '
            Me.officeButton16.AutoToolTip = False
            Me.officeButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton16.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton16.HelpText = "Send a copy of the document in an e-mail " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "message as an attachment."
            Me.officeButton16.Image = CType(resources.GetObject("officeButton16.Image"), System.Drawing.Image)
            Me.officeButton16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeButton16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton16.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton16.Name = "officeButton16"
            Me.officeButton16.Size = New System.Drawing.Size(263, 45)
            Me.officeButton16.Text = "E-mail"
            Me.officeButton16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo31.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo31.Header.Text = "E-mail"
            Me.superToolTip1.SetToolTip(Me.officeButton16, ToolTipInfo31)
            '
            'officeButton17
            '
            Me.officeButton17.AutoToolTip = False
            Me.officeButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton17.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton17.HelpText = "Use an Internet Fax service to fax the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "document."
            Me.officeButton17.Image = CType(resources.GetObject("officeButton17.Image"), System.Drawing.Image)
            Me.officeButton17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeButton17.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton17.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton17.Name = "officeButton17"
            Me.officeButton17.Size = New System.Drawing.Size(263, 45)
            Me.officeButton17.Text = "Internet Fax"
            Me.officeButton17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo32.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo32.Header.Text = "Internet Fax"
            Me.superToolTip1.SetToolTip(Me.officeButton17, ToolTipInfo32)
            '
            'officeDropDownButton4
            '
            Me.officeDropDownButton4.DropDownFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.officeDropDownButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.officeButton18, Me.officeButton19, Me.officeButton20})
            Me.officeDropDownButton4.DropDownText = "Distribute the document to other people"
            Me.officeDropDownButton4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeDropDownButton4.Image = Global.Word2007Demo_2005.My.Resources.Resources.publish_blog_icon
            Me.officeDropDownButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeDropDownButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeDropDownButton4.Name = "officeDropDownButton4"
            Me.officeDropDownButton4.Padding = New System.Windows.Forms.Padding(4)
            Me.officeDropDownButton4.Size = New System.Drawing.Size(121, 44)
            Me.officeDropDownButton4.Text = "P&ublish"
            Me.officeDropDownButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo37.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo37.Header.Text = "Publish"
            Me.superToolTip1.SetToolTip(Me.officeDropDownButton4, ToolTipInfo37)
            '
            'officeButton18
            '
            Me.officeButton18.AutoToolTip = False
            Me.officeButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton18.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton18.HelpText = "Create a new blog post with the contents of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the document."
            Me.officeButton18.Image = CType(resources.GetObject("officeButton18.Image"), System.Drawing.Image)
            Me.officeButton18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeButton18.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton18.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton18.Name = "officeButton18"
            Me.officeButton18.Size = New System.Drawing.Size(263, 45)
            Me.officeButton18.Text = "Blog"
            Me.officeButton18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo34.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo34.Header.Text = "Blog"
            Me.superToolTip1.SetToolTip(Me.officeButton18, ToolTipInfo34)
            '
            'officeButton19
            '
            Me.officeButton19.AutoToolTip = False
            Me.officeButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton19.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton19.HelpText = "Share the document by saving it to a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "document management server."
            Me.officeButton19.Image = CType(resources.GetObject("officeButton19.Image"), System.Drawing.Image)
            Me.officeButton19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeButton19.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton19.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton19.Name = "officeButton19"
            Me.officeButton19.Size = New System.Drawing.Size(263, 45)
            Me.officeButton19.Text = "Document Management Server"
            Me.officeButton19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo35.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo35.Header.Text = "Document Management " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Server"
            Me.superToolTip1.SetToolTip(Me.officeButton19, ToolTipInfo35)
            '
            'officeButton20
            '
            Me.officeButton20.AutoToolTip = False
            Me.officeButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me.officeButton20.ForeColor = System.Drawing.Color.MidnightBlue
            Me.officeButton20.HelpText = "Create a new site for the document and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "keep the local copy synchronized."
            Me.officeButton20.Image = CType(resources.GetObject("officeButton20.Image"), System.Drawing.Image)
            Me.officeButton20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.officeButton20.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.officeButton20.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.officeButton20.Name = "officeButton20"
            Me.officeButton20.Size = New System.Drawing.Size(263, 45)
            Me.officeButton20.Text = "Create Document Workspace"
            Me.officeButton20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ToolTipInfo36.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo36.Header.Text = "Create Document Workspace"
            Me.superToolTip1.SetToolTip(Me.officeButton20, ToolTipInfo36)
            '
            'toolStripSeparator29
            '
            Me.toolStripSeparator29.Name = "toolStripSeparator29"
            Me.toolStripSeparator29.Size = New System.Drawing.Size(105, 2)
            '
            'toolStripButton3
            '
            Me.toolStripButton3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripButton3.Image = Global.Word2007Demo_2005.My.Resources.Resources.close_icon
            Me.toolStripButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton3.Name = "toolStripButton3"
            Me.toolStripButton3.Padding = New System.Windows.Forms.Padding(4)
            Me.toolStripButton3.Size = New System.Drawing.Size(121, 44)
            Me.toolStripButton3.Text = "&Close"
            ToolTipInfo38.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo38.Header.Text = "Close"
            Me.superToolTip1.SetToolTip(Me.toolStripButton3, ToolTipInfo38)
            '
            'toolStripButton6
            '
            Me.toolStripButton6.AutoToolTip = False
            Me.toolStripButton6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripButton6.Image = CType(resources.GetObject("toolStripButton6.Image"), System.Drawing.Image)
            Me.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton6.Name = "toolStripButton6"
            Me.toolStripButton6.Size = New System.Drawing.Size(45, 20)
            Me.toolStripButton6.Text = "E&xit"
            ToolTipInfo39.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo39.Header.Text = "Exit"
            Me.superToolTip1.SetToolTip(Me.toolStripButton6, ToolTipInfo39)
            '
            'toolStripButton4
            '
            Me.toolStripButton4.AutoToolTip = False
            Me.toolStripButton4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripButton4.Image = Global.Word2007Demo_2005.My.Resources.Resources.wordoptions_icon_16
            Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton4.Name = "toolStripButton4"
            Me.toolStripButton4.Size = New System.Drawing.Size(93, 20)
            Me.toolStripButton4.Text = "Word Opt&ions"
            ToolTipInfo40.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo40.Header.Text = "Word Options"
            Me.superToolTip1.SetToolTip(Me.toolStripButton4, ToolTipInfo40)
            '
            'saveToolstripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.saveToolstripBtn, "1")
            Me.saveToolstripBtn.AutoToolTip = False
            Me.saveToolstripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.saveToolstripBtn.Image = CType(resources.GetObject("saveToolstripBtn.Image"), System.Drawing.Image)
            Me.saveToolstripBtn.Name = "saveToolstripBtn"
            Me.SetShortcut(Me.saveToolstripBtn, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys))
            Me.saveToolstripBtn.Size = New System.Drawing.Size(23, 22)
            Me.saveToolstripBtn.Text = "saveToolstripBtn"
            ToolTipInfo203.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo203.Body.Hidden = True
            ToolTipInfo203.Footer.Hidden = True
            ToolTipInfo203.Header.Text = "Save (Ctrl + S)"
            ToolTipInfo203.Separator = False
            Me.superToolTip1.SetToolTip(Me.saveToolstripBtn, ToolTipInfo203)
            '
            'undoToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.undoToolStripBtn, "2")
            Me.undoToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.undoToolStripBtn.Image = CType(resources.GetObject("undoToolStripBtn.Image"), System.Drawing.Image)
            Me.undoToolStripBtn.Name = "undoToolStripBtn"
            Me.SetShortcut(Me.undoToolStripBtn, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys))
            Me.undoToolStripBtn.Size = New System.Drawing.Size(23, 22)
            Me.undoToolStripBtn.Text = "toolStripButton2"
            ToolTipInfo204.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo204.Body.Hidden = True
            ToolTipInfo204.Footer.Hidden = True
            ToolTipInfo204.Header.Text = "Undo (Ctrl + Z)"
            ToolTipInfo204.Separator = False
            Me.superToolTip1.SetToolTip(Me.undoToolStripBtn, ToolTipInfo204)
            '
            'redoToolStripBtn
            '
            Me.superAccelerator.SetAccelerator(Me.redoToolStripBtn, "3")
            Me.redoToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.redoToolStripBtn.Enabled = False
            Me.redoToolStripBtn.Image = CType(resources.GetObject("redoToolStripBtn.Image"), System.Drawing.Image)
            Me.redoToolStripBtn.Name = "redoToolStripBtn"
            Me.SetShortcut(Me.redoToolStripBtn, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys))
            Me.redoToolStripBtn.Size = New System.Drawing.Size(23, 22)
            Me.redoToolStripBtn.Text = "toolStripButton3"
            ToolTipInfo205.BackColor = System.Drawing.SystemColors.Control
            ToolTipInfo205.Body.Hidden = True
            ToolTipInfo205.Footer.Hidden = True
            ToolTipInfo205.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo205.Header.Text = "Redo (Ctrl + Y)"
            ToolTipInfo205.Separator = False
            Me.superToolTip1.SetToolTip(Me.redoToolStripBtn, ToolTipInfo205)
            '
            'superAccelerator
            '
            Me.superAccelerator.BackColor = System.Drawing.SystemColors.Control
            Me.superAccelerator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            'superToolTip1
            '
            Me.superToolTip1.InitialDelay = 1000
            '
            'toolStripButton5
            '
            Me.toolStripButton5.Image = CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image)
            Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton5.Name = "toolStripButton5"
            Me.toolStripButton5.Size = New System.Drawing.Size(265, 20)
            Me.toolStripButton5.Text = "&Word Document"
            ToolTipInfo206.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo206.Header.Text = "Save the document in default file format."
            Me.superToolTip1.SetToolTip(Me.toolStripButton5, ToolTipInfo206)
            '
            'toolStripButton19
            '
            Me.toolStripButton19.Image = CType(resources.GetObject("toolStripButton19.Image"), System.Drawing.Image)
            Me.toolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton19.Name = "toolStripButton19"
            Me.toolStripButton19.Size = New System.Drawing.Size(265, 20)
            Me.toolStripButton19.Text = "Word &Template"
            ToolTipInfo207.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo207.Header.Text = "Save the document as a template that can " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "be used to format future documents."
            Me.superToolTip1.SetToolTip(Me.toolStripButton19, ToolTipInfo207)
            '
            'toolStripButton20
            '
            Me.toolStripButton20.Image = CType(resources.GetObject("toolStripButton20.Image"), System.Drawing.Image)
            Me.toolStripButton20.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton20.Name = "toolStripButton20"
            Me.toolStripButton20.Size = New System.Drawing.Size(265, 20)
            Me.toolStripButton20.Text = "Word &97-2003 Document"
            ToolTipInfo208.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo208.Header.Text = "Save a copy of the document that is fully " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "compatible with Word 97-2003."
            Me.superToolTip1.SetToolTip(Me.toolStripButton20, ToolTipInfo208)
            '
            'toolStripButton21
            '
            Me.toolStripButton21.Image = CType(resources.GetObject("toolStripButton21.Image"), System.Drawing.Image)
            Me.toolStripButton21.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton21.Name = "toolStripButton21"
            Me.toolStripButton21.Size = New System.Drawing.Size(265, 20)
            Me.toolStripButton21.Text = "&Find add-ins for other file formats"
            ToolTipInfo209.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo209.Header.Text = "Learn about add-ins to save to other " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "formats such as PDF or XPS."
            Me.superToolTip1.SetToolTip(Me.toolStripButton21, ToolTipInfo209)
            '
            'toolStripButton22
            '
            Me.toolStripButton22.Image = CType(resources.GetObject("toolStripButton22.Image"), System.Drawing.Image)
            Me.toolStripButton22.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton22.Name = "toolStripButton22"
            Me.toolStripButton22.Size = New System.Drawing.Size(265, 20)
            Me.toolStripButton22.Text = "&Other Formats"
            ToolTipInfo210.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo210.Header.Text = "Open the Save as dialog box to select from " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "all possible file types."
            Me.superToolTip1.SetToolTip(Me.toolStripButton22, ToolTipInfo210)
            '
            'statusStripButton4
            '
            Me.statusStripButton4.AutoToolTip = False
            Me.statusStripButton4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.statusStripButton4.Margin = New System.Windows.Forms.Padding(0, 4, 0, 2)
            Me.statusStripButton4.Name = "statusStripButton4"
            Me.statusStripButton4.Size = New System.Drawing.Size(67, 17)
            Me.statusStripButton4.Text = "Words"
            Me.statusStripButton4.StatusString = "100"
            ToolTipInfo4.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo4.Header.Text = "Words: 100"
            Me.superToolTip1.SetToolTip(Me.statusStripButton4, ToolTipInfo4)
            '
            'statusStripButton5
            '
            Me.statusStripButton5.AutoToolTip = False
            Me.statusStripButton5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.statusStripButton5.Margin = New System.Windows.Forms.Padding(0, 4, 0, 2)
            Me.statusStripButton5.Name = "statusStripButton5"
            Me.statusStripButton5.Size = New System.Drawing.Size(72, 17)
            Me.statusStripButton5.Text = "English (U.S)"
            Me.statusStripButton5.StatusString = "On"
            ToolTipInfo5.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo5.Header.Text = "English (U.S)"
            Me.superToolTip1.SetToolTip(Me.statusStripButton5, ToolTipInfo5)
            '
            'statusStripButton1
            '
            Me.statusStripButton1.AutoToolTip = False
            Me.statusStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.statusStripButton1.Image = CType(resources.GetObject("statusStripButton1.Image"), System.Drawing.Image)
            Me.statusStripButton1.Margin = New System.Windows.Forms.Padding(0, 4, 0, 2)
            Me.statusStripButton1.Name = "statusStripButton1"
            Me.statusStripButton1.Size = New System.Drawing.Size(23, 20)
            Me.statusStripButton1.Text = "List"
            Me.statusStripButton1.StatusString = "On"
            ToolTipInfo1.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo1.Header.ForeColor = System.Drawing.Color.Black
            ToolTipInfo1.Header.Text = "Text"
            Me.superToolTip1.SetToolTip(Me.statusStripButton1, ToolTipInfo1)
            '
            'statusStripButton2
            '
            Me.statusStripButton2.AutoToolTip = False
            Me.statusStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.statusStripButton2.Image = CType(resources.GetObject("statusStripButton2.Image"), System.Drawing.Image)
            Me.statusStripButton2.Margin = New System.Windows.Forms.Padding(0, 4, 0, 2)
            Me.statusStripButton2.Name = "statusStripButton2"
            Me.statusStripButton2.Size = New System.Drawing.Size(23, 20)
            Me.statusStripButton2.Text = "Check"
            Me.statusStripButton2.StatusString = "On"
            ToolTipInfo2.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo2.Header.Text = "Check List"
            Me.superToolTip1.SetToolTip(Me.statusStripButton2, ToolTipInfo2)
            '
            'fontListBox1
            '
            Me.fontListBox1.FormattingEnabled = True
            Me.fontListBox1.ItemHeight = 15
            Me.fontListBox1.Location = New System.Drawing.Point(248, 360)
            Me.fontListBox1.Name = "fontListBox1"
            Me.fontListBox1.Size = New System.Drawing.Size(120, 94)
            Me.fontListBox1.TabIndex = 1
            Me.fontListBox1.Visible = False
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.CornflowerBlue, System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer)))
            Me.gradientPanel1.BorderColor = System.Drawing.Color.Black
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel1.Controls.Add(Me.richTextBox1)
            Me.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gradientPanel1.Location = New System.Drawing.Point(5, 153)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(1000, 431)
            Me.gradientPanel1.TabIndex = 4
            '
            'richTextBox1
            '
            Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.richTextBox1.ContextMenuStrip = Me.EditorContextMenuStripEx
            Me.richTextBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.richTextBox1.Location = New System.Drawing.Point(30, 30)
            Me.gridLayout1.SetMinimumSize(Me.richTextBox1, New System.Drawing.Size(1086, 327))
            Me.richTextBox1.Name = "richTextBox1"
            Me.gridLayout1.SetParticipateInLayout(Me.richTextBox1, True)
            Me.gridLayout1.SetPreferredSize(Me.richTextBox1, New System.Drawing.Size(1086, 327))
            Me.richTextBox1.Size = New System.Drawing.Size(940, 371)
            Me.richTextBox1.TabIndex = 0
            Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
            '
            'EditorContextMenuStripEx
            '
            Me.EditorContextMenuStripEx.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1, Me.toolStripMenuItem9, Me.toolStripMenuItem10, Me.toolStripSeparator30, Me.toolStripMenuItem11, Me.toolStripMenuItem12, Me.toolStripSeparator31, Me.toolStripMenuItem14})
            Me.EditorContextMenuStripEx.Name = "EditorContextMenuStripEx"
            Me.EditorContextMenuStripEx.Size = New System.Drawing.Size(148, 148)
            '
            'toolStripMenuItem1
            '
            Me.toolStripMenuItem1.Image = CType(resources.GetObject("toolStripMenuItem1.Image"), System.Drawing.Image)
            Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
            Me.toolStripMenuItem1.Size = New System.Drawing.Size(147, 22)
            Me.toolStripMenuItem1.Text = "Cu&t"
            '
            'toolStripMenuItem9
            '
            Me.toolStripMenuItem9.Image = CType(resources.GetObject("toolStripMenuItem9.Image"), System.Drawing.Image)
            Me.toolStripMenuItem9.Name = "toolStripMenuItem9"
            Me.toolStripMenuItem9.Size = New System.Drawing.Size(147, 22)
            Me.toolStripMenuItem9.Text = "&Copy"
            '
            'toolStripMenuItem10
            '
            Me.toolStripMenuItem10.Image = CType(resources.GetObject("toolStripMenuItem10.Image"), System.Drawing.Image)
            Me.toolStripMenuItem10.Name = "toolStripMenuItem10"
            Me.toolStripMenuItem10.Size = New System.Drawing.Size(147, 22)
            Me.toolStripMenuItem10.Text = "&Paste"
            '
            'toolStripSeparator30
            '
            Me.toolStripSeparator30.Name = "toolStripSeparator30"
            Me.toolStripSeparator30.Size = New System.Drawing.Size(144, 6)
            '
            'toolStripMenuItem11
            '
            Me.toolStripMenuItem11.Image = CType(resources.GetObject("toolStripMenuItem11.Image"), System.Drawing.Image)
            Me.toolStripMenuItem11.Name = "toolStripMenuItem11"
            Me.toolStripMenuItem11.Size = New System.Drawing.Size(147, 22)
            Me.toolStripMenuItem11.Text = "&Font..."
            '
            'toolStripMenuItem12
            '
            Me.toolStripMenuItem12.Image = CType(resources.GetObject("toolStripMenuItem12.Image"), System.Drawing.Image)
            Me.toolStripMenuItem12.Name = "toolStripMenuItem12"
            Me.toolStripMenuItem12.Size = New System.Drawing.Size(147, 22)
            Me.toolStripMenuItem12.Text = "&Paragraph..."
            '
            'toolStripSeparator31
            '
            Me.toolStripSeparator31.Name = "toolStripSeparator31"
            Me.toolStripSeparator31.Size = New System.Drawing.Size(144, 6)
            '
            'toolStripMenuItem14
            '
            Me.toolStripMenuItem14.Image = CType(resources.GetObject("toolStripMenuItem14.Image"), System.Drawing.Image)
            Me.toolStripMenuItem14.Name = "toolStripMenuItem14"
            Me.toolStripMenuItem14.Size = New System.Drawing.Size(147, 22)
            Me.toolStripMenuItem14.Text = "&Hyperlink"
            '
            'gridLayout1
            '
            Me.gridLayout1.BottomMargin = 30
            Me.gridLayout1.Columns = 0
            Me.gridLayout1.ContainerControl = Me.gradientPanel1
            Me.gridLayout1.HorzFarMargin = 30
            Me.gridLayout1.HorzNearMargin = 30
            Me.gridLayout1.Rows = 1
            Me.gridLayout1.TopMargin = 30
            '
            'progressTimer
            '
            Me.progressTimer.Interval = 30
            '
            'statusStripEx1
            '
            Me.statusStripEx1.AllowItemReorder = True
            Me.statusStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.trackBarItem1, Me.statusStripButton1, Me.statusStripButton2, Me.statusStripLabel1, Me.statusStripButton4, Me.statusStripButton5})
            Me.statusStripEx1.Location = New System.Drawing.Point(1, 581)
            Me.statusStripEx1.Name = "statusStripEx1"
            Me.statusStripEx1.Size = New System.Drawing.Size(1008, 26)
            Me.statusStripEx1.TabIndex = 7
            Me.statusStripEx1.Text = "statusStripEx1"
            '
            'trackBarItem1
            '
            Me.trackBarItem1.Maximum = 10
            Me.trackBarItem1.Name = "trackBarItem1"
            Me.trackBarItem1.Size = New System.Drawing.Size(200, 20)
            Me.trackBarItem1.Text = "TrackBar"
            Me.trackBarItem1.Value = 5
            '
            'MiniToolBar
            '
            Me.MiniToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiniToolBarPanelItem})
            Me.MiniToolBar.Name = "MiniToolBar"
            Me.MiniToolBar.Size = New System.Drawing.Size(216, 62)
            '
            'MiniToolBarPanelItem
            '
            Me.MiniToolBarPanelItem.CausesValidation = False
            Me.MiniToolBarPanelItem.ForeColor = System.Drawing.Color.MidnightBlue
            Me.MiniToolBarPanelItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PanelItem1, Me.PanelItem2})
            Me.MiniToolBarPanelItem.Name = "MiniToolBarPanelItem"
            Me.MiniToolBarPanelItem.RowCount = 2
            Me.MiniToolBarPanelItem.Size = New System.Drawing.Size(212, 58)
            Me.MiniToolBarPanelItem.Text = "Container"
            Me.MiniToolBarPanelItem.Transparent = True
            '
            'PanelItem1
            '
            Me.PanelItem1.CausesValidation = False
            Me.PanelItem1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.PanelItem1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontFaceCombo, Me.FontSize, Me.toolStripButton10, Me.toolStripButton11})
            Me.PanelItem1.Name = "PanelItem1"
            Me.PanelItem1.RowCount = 1
            Me.PanelItem1.Size = New System.Drawing.Size(206, 27)
            Me.PanelItem1.Text = "toolStripPanelItem49"
            Me.PanelItem1.Transparent = True
            '
            'FontFaceCombo
            '
            Me.FontFaceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.FontFaceCombo.Name = "FontFaceCombo"
            Me.FontFaceCombo.Size = New System.Drawing.Size(112, 21)
            '
            'FontSize
            '
            Me.FontSize.AutoSize = False
            Me.FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.FontSize.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72"})
            Me.FontSize.Name = "FontSize"
            Me.FontSize.Size = New System.Drawing.Size(40, 21)
            '
            'toolStripButton10
            '
            Me.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton10.Image = CType(resources.GetObject("toolStripButton10.Image"), System.Drawing.Image)
            Me.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton10.Name = "toolStripButton10"
            Me.toolStripButton10.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton10.Text = "toolStripButton10"
            '
            'toolStripButton11
            '
            Me.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton11.Image = CType(resources.GetObject("toolStripButton11.Image"), System.Drawing.Image)
            Me.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton11.Name = "toolStripButton11"
            Me.toolStripButton11.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton11.Text = "toolStripButton11"
            '
            'PanelItem2
            '
            Me.PanelItem2.CausesValidation = False
            Me.PanelItem2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.PanelItem2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton12, Me.toolStripButton13, Me.toolStripButton14, Me.toolStripButton17, Me.toolStripSplitButton1, Me.toolStripSplitButton2, Me.toolStripButton15, Me.toolStripButton16})
            Me.PanelItem2.Name = "PanelItem2"
            Me.PanelItem2.RowCount = 1
            Me.PanelItem2.Size = New System.Drawing.Size(188, 27)
            Me.PanelItem2.Text = "toolStripPanelItem50"
            Me.PanelItem2.Transparent = True
            '
            'toolStripButton12
            '
            Me.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton12.Image = CType(resources.GetObject("toolStripButton12.Image"), System.Drawing.Image)
            Me.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton12.Name = "toolStripButton12"
            Me.toolStripButton12.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton12.Text = "toolStripButton12"
            '
            'toolStripButton13
            '
            Me.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton13.Image = CType(resources.GetObject("toolStripButton13.Image"), System.Drawing.Image)
            Me.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton13.Name = "toolStripButton13"
            Me.toolStripButton13.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton13.Text = "toolStripButton13"
            '
            'toolStripButton14
            '
            Me.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton14.Image = CType(resources.GetObject("toolStripButton14.Image"), System.Drawing.Image)
            Me.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton14.Name = "toolStripButton14"
            Me.toolStripButton14.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton14.Text = "toolStripButton14"
            '
            'toolStripButton17
            '
            Me.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton17.Image = CType(resources.GetObject("toolStripButton17.Image"), System.Drawing.Image)
            Me.toolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton17.Name = "toolStripButton17"
            Me.toolStripButton17.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton17.Text = "toolStripButton17"
            '
            'toolStripSplitButton1
            '
            Me.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripSplitButton1.Image = CType(resources.GetObject("toolStripSplitButton1.Image"), System.Drawing.Image)
            Me.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripSplitButton1.Name = "toolStripSplitButton1"
            Me.toolStripSplitButton1.Size = New System.Drawing.Size(23, 20)
            Me.toolStripSplitButton1.Text = "toolStripSplitButton1"
            '
            'toolStripSplitButton2
            '
            Me.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripSplitButton2.Image = CType(resources.GetObject("toolStripSplitButton2.Image"), System.Drawing.Image)
            Me.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripSplitButton2.Name = "toolStripSplitButton2"
            Me.toolStripSplitButton2.Size = New System.Drawing.Size(23, 20)
            Me.toolStripSplitButton2.Text = "toolStripSplitButton2"
            '
            'toolStripButton15
            '
            Me.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton15.Image = CType(resources.GetObject("toolStripButton15.Image"), System.Drawing.Image)
            Me.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton15.Name = "toolStripButton15"
            Me.toolStripButton15.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton15.Text = "toolStripButton15"
            '
            'toolStripButton16
            '
            Me.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton16.Image = CType(resources.GetObject("toolStripButton16.Image"), System.Drawing.Image)
            Me.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton16.Name = "toolStripButton16"
            Me.toolStripButton16.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton16.Text = "toolStripButton16"
            '
            'SplashControl1
            '
            Me.SplashControl1.AutoMode = False
            Me.SplashControl1.CustomSplashPanel = Me.SplashPanel1
            Me.SplashControl1.HideHostForm = True
            Me.SplashControl1.HostForm = Me
            Me.SplashControl1.UseCustomSplashPanel = True
            '
            'SplashPanel1
            '
            Me.SplashPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.HighlightText)
            Me.SplashPanel1.BackgroundImage = CType(resources.GetObject("SplashPanel1.BackgroundImage"), System.Drawing.Image)
            Me.SplashPanel1.BorderType = Syncfusion.Windows.Forms.Tools.SplashBorderType.None
            Me.SplashPanel1.DiscreetLocation = New System.Drawing.Point(0, 0)
            Me.SplashPanel1.Location = New System.Drawing.Point(322, 506)
            Me.SplashPanel1.Name = "SplashPanel1"
            Me.SplashPanel1.Size = New System.Drawing.Size(430, 230)
            Me.SplashPanel1.TabIndex = 8
            Me.SplashPanel1.Text = "SplashPanel1"
            '
            'statusStripLabel1
            '
            Me.statusStripLabel1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.statusStripLabel1.Margin = New System.Windows.Forms.Padding(0, 4, 0, 2)
            Me.statusStripLabel1.Name = "statusStripLabel1"
            Me.statusStripLabel1.Size = New System.Drawing.Size(59, 13)
            Me.statusStripLabel1.Text = "Pages"
            Me.statusStripLabel1.StatusString = "1/1"
            ToolTipInfo3.BackColor = System.Drawing.SystemColors.ButtonFace
            ToolTipInfo3.Header.Text = "Pages: 1/1"
            Me.superToolTip1.SetToolTip(Me.statusStripLabel1, ToolTipInfo3)
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.HelpButton=True
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Borders = New System.Windows.Forms.Padding(8, 1, 8, 8)
            Me.ClientSize = New System.Drawing.Size(1010, 609)
            Me.Controls.Add(Me.statusStripEx1)
            Me.Controls.Add(Me.gradientPanel1)
            Me.Controls.Add(Me.fontListBox1)
            Me.Controls.Add(Me.ribbonControlAdv1)
            Me.Controls.Add(Me.SplashPanel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(6, 2, 6, 0)
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Word 2007 Demo"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ribbonControlAdv1.ResumeLayout(False)
            Me.ribbonControlAdv1.PerformLayout()
            Me.homeTabItem.Panel.ResumeLayout(False)
            Me.homeTabItem.Panel.PerformLayout()
            Me.clipboardToolStripExt.ResumeLayout(False)
            Me.clipboardToolStripExt.PerformLayout()
            Me.fontToolStripExt.ResumeLayout(False)
            Me.fontToolStripExt.PerformLayout()
            Me.paragraphToolStripExt.ResumeLayout(False)
            Me.paragraphToolStripExt.PerformLayout()
            Me.stylesToolStripExt.ResumeLayout(False)
            Me.stylesToolStripExt.PerformLayout()
            Me.editingToolStripExt.ResumeLayout(False)
            Me.editingToolStripExt.PerformLayout()
            Me.insertTabItem.Panel.ResumeLayout(False)
            Me.insertTabItem.Panel.PerformLayout()
            Me.pagesToolStripExt.ResumeLayout(False)
            Me.pagesToolStripExt.PerformLayout()
            Me.tablesToolStripExt.ResumeLayout(False)
            Me.tablesToolStripExt.PerformLayout()
            Me.linksToolStripExt.ResumeLayout(False)
            Me.linksToolStripExt.PerformLayout()
            Me.headerToolStripExt.ResumeLayout(False)
            Me.headerToolStripExt.PerformLayout()
            Me.textToolStripExt.ResumeLayout(False)
            Me.textToolStripExt.PerformLayout()
            Me.symbolsToolStripExt.ResumeLayout(False)
            Me.symbolsToolStripExt.PerformLayout()
            Me.pageLayoutTabItem.Panel.ResumeLayout(False)
            Me.pageLayoutTabItem.Panel.PerformLayout()
            Me.themesToolStripExt.ResumeLayout(False)
            Me.themesToolStripExt.PerformLayout()
            Me.pageSetupToolStripExt.ResumeLayout(False)
            Me.pageSetupToolStripExt.PerformLayout()
            Me.pageBackgroundToolStripExt.ResumeLayout(False)
            Me.pageBackgroundToolStripExt.PerformLayout()
            Me.paraToolStripExt.ResumeLayout(False)
            Me.paraToolStripExt.PerformLayout()
            Me.arrangeToolStripExt.ResumeLayout(False)
            Me.arrangeToolStripExt.PerformLayout()
            Me.referencesTabItem.Panel.ResumeLayout(False)
            Me.referencesTabItem.Panel.PerformLayout()
            Me.tbofContentsToolStripExt.ResumeLayout(False)
            Me.tbofContentsToolStripExt.PerformLayout()
            Me.footNotesToolStripExt.ResumeLayout(False)
            Me.footNotesToolStripExt.PerformLayout()
            Me.citationsToolStripExt.ResumeLayout(False)
            Me.citationsToolStripExt.PerformLayout()
            Me.captionsToolStripExt.ResumeLayout(False)
            Me.captionsToolStripExt.PerformLayout()
            Me.indexToolStripExt.ResumeLayout(False)
            Me.indexToolStripExt.PerformLayout()
            Me.tbofAuthoritiesToolStripExt.ResumeLayout(False)
            Me.tbofAuthoritiesToolStripExt.PerformLayout()
            Me.mailingsTabItem.Panel.ResumeLayout(False)
            Me.mailingsTabItem.Panel.PerformLayout()
            Me.createToolStripExt.ResumeLayout(False)
            Me.createToolStripExt.PerformLayout()
            Me.stMailMergeToolStripExt.ResumeLayout(False)
            Me.stMailMergeToolStripExt.PerformLayout()
            Me.insertFieldsToolStripExt.ResumeLayout(False)
            Me.insertFieldsToolStripExt.PerformLayout()
            Me.previewResultsToolStripExt.ResumeLayout(False)
            Me.previewResultsToolStripExt.PerformLayout()
            Me.finishToolStripExt.ResumeLayout(False)
            Me.finishToolStripExt.PerformLayout()
            Me.reviewTabItem.Panel.ResumeLayout(False)
            Me.reviewTabItem.Panel.PerformLayout()
            Me.proofingToolStripExt.ResumeLayout(False)
            Me.proofingToolStripExt.PerformLayout()
            Me.commentsToolStripExt.ResumeLayout(False)
            Me.commentsToolStripExt.PerformLayout()
            Me.trackingToolStripExt.ResumeLayout(False)
            Me.trackingToolStripExt.PerformLayout()
            Me.changesToolStripExt.ResumeLayout(False)
            Me.changesToolStripExt.PerformLayout()
            Me.compareToolStripExt.ResumeLayout(False)
            Me.compareToolStripExt.PerformLayout()
            Me.toolStripEx6.ResumeLayout(False)
            Me.toolStripEx6.PerformLayout()
            Me.viewTabItem.Panel.ResumeLayout(False)
            Me.viewTabItem.Panel.PerformLayout()
            Me.docViewsToolStripExt.ResumeLayout(False)
            Me.docViewsToolStripExt.PerformLayout()
            Me.showToolStripExt.ResumeLayout(False)
            Me.showToolStripExt.PerformLayout()
            Me.zoomToolStripExt.ResumeLayout(False)
            Me.zoomToolStripExt.PerformLayout()
            Me.windowToolStripExt.ResumeLayout(False)
            Me.windowToolStripExt.PerformLayout()
            Me.macrosToolStripEx.ResumeLayout(False)
            Me.macrosToolStripEx.PerformLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.EditorContextMenuStripEx.ResumeLayout(False)
            CType(Me.gridLayout1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.statusStripEx1.ResumeLayout(False)
            Me.statusStripEx1.PerformLayout()
            Me.MiniToolBar.ResumeLayout(False)
            Me.MiniToolBar.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

				#End Region

				Private WithEvents ribbonControlAdv1 As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
				Private saveToolstripBtn As System.Windows.Forms.ToolStripButton
				Private WithEvents undoToolStripBtn As System.Windows.Forms.ToolStripButton
				Private WithEvents redoToolStripBtn As System.Windows.Forms.ToolStripButton
				Private homeTabItem As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
				Private clipboardToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private toolStripPanelItem1 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private WithEvents toolStripBtnCut As System.Windows.Forms.ToolStripButton
				Private WithEvents toolStripBtnCopy As System.Windows.Forms.ToolStripButton
				Private toolStripBtnPaint As System.Windows.Forms.ToolStripButton
				Private insertTabItem As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
				Private pageLayoutTabItem As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
				Private referencesTabItem As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
				Private mailingsTabItem As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
				Private reviewTabItem As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
				Private viewTabItem As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
				Private fontToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private toolStripPanelItem2 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private WithEvents toolStripFontfaceComboBox As System.Windows.Forms.ToolStripComboBox
				Private WithEvents toolStripFontSizeComboBox As System.Windows.Forms.ToolStripComboBox
				Private toolStripPanelItem3 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private WithEvents growfontToolStripBtn As System.Windows.Forms.ToolStripButton
				Private WithEvents shrinkfontToolStripBtn As System.Windows.Forms.ToolStripButton
				Private toolStripPanelItem4 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private WithEvents boldToolstripBtn As System.Windows.Forms.ToolStripButton
				Private WithEvents italicToolStripBtn As System.Windows.Forms.ToolStripButton
				Private WithEvents underlineToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private toolStripPanelItem5 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private subscriptToolStripBtn As System.Windows.Forms.ToolStripButton
				Private superscriptToolStripBtn As System.Windows.Forms.ToolStripButton
				Private toolStripPanelItem6 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private txthighltToolStripsplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private fontcolorToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private paragraphToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private toolStripPanelItem7 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private bulletToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private numberingToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private multilevelToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private toolStripPanelItem8 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private WithEvents deindentToolStripBtn As System.Windows.Forms.ToolStripButton
				Private WithEvents inindentToolStripBtn As System.Windows.Forms.ToolStripButton
				Private shadingToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private btmborderToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private stylesToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private editingToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private toolStripPanelItem10 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private replaceToolStripBtn As System.Windows.Forms.ToolStripButton
				Private selectToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
		Private qckstylesToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private superAccelerator As Syncfusion.Windows.Forms.Tools.SuperAccelerator
				Private pagesToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private coverPageToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private blankPageToolStripBtn As System.Windows.Forms.ToolStripButton
				Private pageBreakToolStripBtn As System.Windows.Forms.ToolStripButton
				Private tablesToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private tableToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private linksToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private hyperlinkToolStripBtn As System.Windows.Forms.ToolStripButton
				Private bookmarkToolStripBtn As System.Windows.Forms.ToolStripButton
				Private crossrefToolStripBtn As System.Windows.Forms.ToolStripButton
				Private headerToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private headerToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private footerToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private pagenoToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private textToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private txtboxToolStripSplitBtn As System.Windows.Forms.ToolStripDropDownButton
				Private toolStripPanelItem11 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private toolStripPanelItem12 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private qckPartsToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private wordArtToolStripSplitBtn As System.Windows.Forms.ToolStripDropDownButton
				Private signLineToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private dateTimeToolStripBtn As System.Windows.Forms.ToolStripButton
				Private objectToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private symbolsToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private themesToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private toolStripPanelItem13 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private pageSetupToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private marginToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private toolStripPanelItem14 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private breaksToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private lnumbersToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private hyphenationToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private pageBackgroundToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private watermarkToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private pageColorToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private pageBordersToolStripBtn As System.Windows.Forms.ToolStripButton
				Private WithEvents strikethroToolStripBtn As System.Windows.Forms.ToolStripButton
				Private lspacingToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private bottomBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private topBoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private leftBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private rightBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
				Private noBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private allBordersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private outsideBordersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private insideBordersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
				Private insideHorizontalBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private insideVerticalBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private diagonalDownBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private diagonalUpBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
				Private horizontalLineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
				Private showGridlinesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private bordersAndShadingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private superToolTip1 As Syncfusion.Windows.Forms.Tools.SuperToolTip
				Private toolStripPanelItem15 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private WithEvents toolStripBtnPaste As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownBtnPaste As System.Windows.Forms.ToolStripDropDownButton
				Private themeColorToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private themeFontToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private themeEffectsToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private paraToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private toolStripPanelItem17 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private indentToolStripLabel As System.Windows.Forms.ToolStripLabel
				Private toolStripPanelItem19 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private toolStripPanelItem20 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
				Private toolStripPanelItem18 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private spacingToolStripLabel As System.Windows.Forms.ToolStripLabel
				Private toolStripPanelItem21 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private toolStripPanelItem22 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private lindentToolStripLabel As System.Windows.Forms.ToolStripLabel
				Private ToolStriplindentComboBox As System.Windows.Forms.ToolStripComboBox
				Private rindentToolStripLabel As System.Windows.Forms.ToolStripLabel
				Private ToolStriprindentComboBox As System.Windows.Forms.ToolStripComboBox
				Private pasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private pasteSpecialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private pasteAsHyperlinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private fontListBox1 As Syncfusion.Windows.Forms.Tools.FontListBox
				Private moreUnderlinesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private underlineColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private automaticToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private moreColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private noColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private stopHighlightingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private automaticToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
				Private changeListLevelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private defineNewBulletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private changeListLevelToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
				Private defineNewNumberFormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private setNumberingValueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private changeListLevelToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
				Private defineNewMultilevelListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
				Private defineNewListStyleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
				Private toolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
				Private toolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
				Private toolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
				Private toolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
				Private toolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
				Private moreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
				Private addSpaceBeforeParagraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private removeSpaceAfterParagraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private noColorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
				Private moreShadingColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private WithEvents selectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private selectObjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private selectTextWithSimilarFormattingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel

				Private symbolToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private sbeforeToolStripLabel As System.Windows.Forms.ToolStripLabel
				Private ToolStripsbeforeComboBox As System.Windows.Forms.ToolStripComboBox
				Private safterToolStripLabel As System.Windows.Forms.ToolStripLabel
				Private ToolStripsafterComboBox As System.Windows.Forms.ToolStripComboBox
				Private arrangeToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private positionToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private toolStripPanelItem23 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private bringToFrontToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private sendToBackToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private txtwrapToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private toolStripPanelItem24 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private alignToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private groupToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private rotateToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private themesToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private resetToThemeFromTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private searchOfficeOnlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private browseForThemesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private saveCurrentThemeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private createNewThemeColorsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
				Private createNewThemeFontsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
				Private customMarginsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private noneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private continuousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private restartEachPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private restartEachSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private suppressForCurrentSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
				Private moreLineNumberingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private noneToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
				Private automaticToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
				Private manualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
				Private hyphenationOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private moreWatermarksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private removeWatermartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private saveSelectionToWatermarkGalleryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private noColorToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
				Private moreColorsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
				Private fillEffectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private alignLeftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private alignCenterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private alignRightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
				Private alignTopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private alignMiddleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private alignBottomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private distributreHorizontallyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private distributeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
				Private alignToPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private alToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
				Private alignSelectedObjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
				Private showGridlinesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
				Private gridSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private formatPageNumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private removeCurrentCoverPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private saveSelectionToCoverPageGalleryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private insertTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private drawTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private convertTextToTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private excelSpreadsheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private quickTablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private saveSelectionToQuickTablToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private editHeaderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private removeHeaderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private saveSelectionToHeaderGalleryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private editFooterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private removeFooterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private saveSelectionToFooterGalleryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private topOfPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private bottomOfPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private pageMarginsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private formatPageNumbersToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
				Private removePageNumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private headerFooterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private saveSelectionAsPageNumberTopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private headerFooterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
				Private saveSelectionAsPageNumberBottomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private sAveSelectionAsPageMarginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private drawTextBoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private saveSelectionToTextBoxGalleryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private propertyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private fieldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private pageNumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private buildingBlocksOrganizerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private getMoreOnOfficeOnlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private saveSelectionToQuickPartGalleryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
				Private abstractToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private authorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private categoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private commentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private companyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private companyAddressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private companyEmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private companyFaxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private companyPhoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private keywordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private managerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private publishDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private statusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private subjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private titleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private saveSelectionToPageNumberGalleryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private advancedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private microsoftOfficeSignatureLineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator19 As System.Windows.Forms.ToolStripSeparator
				Private addSignatureServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private textFromFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private objectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private equationToolStripDropDwnBtn As System.Windows.Forms.ToolStripSplitButton
				Private insertNewEquationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private saveSelectionToEquationGalleryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private moreSymbolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private tbofContentsToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private toolStripPanelItem25 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private addtxtToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private updateTableToolStripBtn As System.Windows.Forms.ToolStripButton
				Private footNotesToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private inftnoteToolStripBtn As System.Windows.Forms.ToolStripButton
				Private toolStripPanelItem26 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private inendnoteToolStripBtn As System.Windows.Forms.ToolStripButton
				Private nxtftnoteToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
				Private shNotesToolStripBtn As System.Windows.Forms.ToolStripButton
				Private nextFootnoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private previousFootnoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private nextEndnoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private prevToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private citationsToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private inCaptionToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private addNewSourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private addNewPlaceholderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private searchLibrariesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripPanelItem27 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private mgeSourcesToolStripBtn As System.Windows.Forms.ToolStripButton
				Private toolStripPanelItem28 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private bibliographyToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private styleToolStripLabel As System.Windows.Forms.ToolStripLabel
				Private ToolStripStyleComboBox As System.Windows.Forms.ToolStripComboBox
				Private insertBibliographyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private saveSelectionToBibliographyGalleryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private saveAsNewBibliographyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private captionsToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private inCaptionToolStripBtn As System.Windows.Forms.ToolStripButton
				Private toolStripPanelItem29 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private inTbofFiguresToolStripBtn As System.Windows.Forms.ToolStripButton
				Private upTableToolStripBtn As System.Windows.Forms.ToolStripButton
				Private crrefToolStripBtn As System.Windows.Forms.ToolStripButton
				Private indexToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private toolStripPanelItem30 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private inIndexToolStripBtn As System.Windows.Forms.ToolStripButton
				Private uIndexToolStripBtn As System.Windows.Forms.ToolStripButton
				Private tbofAuthoritiesToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private toolStripPanelItem31 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private inTbofAuthoritiesToolStripBtn As System.Windows.Forms.ToolStripButton
				Private uTableToolStripBtn As System.Windows.Forms.ToolStripButton
				Private createToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private envelopeToolStripBtn As System.Windows.Forms.ToolStripButton
				Private labelsToolStripBtn As System.Windows.Forms.ToolStripButton
				Private stMailMergeToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private stMailMergeToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private lettersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private emailMessagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private envelopesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private lablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private directoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
				Private normalWordDocumentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator21 As System.Windows.Forms.ToolStripSeparator
				Private stepByStepMailMergeWizardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private sltRecipientsToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private typeNewListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private useExistingListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private selectFromOutlookContactsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private editRecepientsToolStripBtn As System.Windows.Forms.ToolStripButton
				Private insertFieldsToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private highltMergeToolStripBtn As System.Windows.Forms.ToolStripButton
				Private addBlockToolStripBtn As System.Windows.Forms.ToolStripButton
				Private greetingToolStripBtn As System.Windows.Forms.ToolStripButton
				Private toolStripPanelItem32 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private rulesToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private matchFieldsToolStripBtn As System.Windows.Forms.ToolStripButton
				Private upLablesToolStripBtn As System.Windows.Forms.ToolStripButton
				Private previewResultsToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private previewResultsToolStripBtn As System.Windows.Forms.ToolStripButton
				Private toolStripSeparator22 As System.Windows.Forms.ToolStripSeparator
				Private toolStripPanelItem33 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private toolStripPanelItem34 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private firstToolStripBtn As System.Windows.Forms.ToolStripButton
				Private previousToolStripBtn As System.Windows.Forms.ToolStripButton
				Private recordToolStripTextBox As System.Windows.Forms.ToolStripTextBox
				Private nxtToolStripBtn As System.Windows.Forms.ToolStripButton
				Private lstToolStripBtn As System.Windows.Forms.ToolStripButton
				Private fndRecepientToolStripBtn As System.Windows.Forms.ToolStripButton
				Private checkErrorToolStripBtn As System.Windows.Forms.ToolStripButton
				Private finishToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private proofingToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private spellToolStripBtn As System.Windows.Forms.ToolStripButton
				Private toolStripPanelItem35 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private researchToolStripBtn As System.Windows.Forms.ToolStripButton
				Private thesaurusToolStripBtn As System.Windows.Forms.ToolStripButton
				Private translateToolStripBtn As System.Windows.Forms.ToolStripButton
				Private toolStripPanelItem36 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private translateTooltipToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private setLangToolStripBtn As System.Windows.Forms.ToolStripButton
				Private wordCntToolStripBtn As System.Windows.Forms.ToolStripButton
				Private englishUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
				Private spanishInternationalSortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private turnOffTranslationToolTipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private commentsToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private nwCommentToolStripBtn As System.Windows.Forms.ToolStripButton
				Private toolStripPanelItem37 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private delToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private preToolStripBtn As System.Windows.Forms.ToolStripButton
				Private nxttToolStripBtn As System.Windows.Forms.ToolStripButton
				Private deleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private deleteAllCommentsShownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private deleteAllCommentsInDocumentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private trackingToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private trkChangesToolStripSplitButton As System.Windows.Forms.ToolStripSplitButton
				Private toolStripPanelItem38 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private toolStripReviewComboBox As System.Windows.Forms.ToolStripComboBox
				Private reviewPaneToolStripSplitButton As System.Windows.Forms.ToolStripSplitButton
				Private trackChangesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private changeTrackingOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private changeUserNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private balloonsToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private showRevisionsInballoonsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private showAllRevisionsInlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private showOnlycommentsAndFormattingInBallonsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private shMarkUpToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private commentsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
				Private inkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private insertionsAndDeletionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private formattingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private markupAreaHighlightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private revieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private allReviewersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private reviewingPaneVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private reviewingPaneHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private changesToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private acceptToolStripSplitButton As System.Windows.Forms.ToolStripSplitButton
				Private toolStripPanelItem39 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private prevToolStripBtn As System.Windows.Forms.ToolStripButton
				Private nextToolStripBtn As System.Windows.Forms.ToolStripButton
				Private acceptAndMoveToNextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private acceptChangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private acceptAllChangesShownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private acceptAllChangesInDocumentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private compareToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private compareToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private shSrcDocToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private hideSourceDocumentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private showOriginalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private showRevisedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private showBothToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private docViewsToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private printLayoutToolStripBtn As System.Windows.Forms.ToolStripButton
				Private fullScrToolStripBtn As System.Windows.Forms.ToolStripButton
				Private showToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private toolStripPanelItem40 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
        Private toolStripPanelItem41 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
        Private zoomToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private zoomToolStripBtn As System.Windows.Forms.ToolStripButton
				Private toolStripPanelItem42 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private onePgToolStripBtn As System.Windows.Forms.ToolStripButton
				Private twoPgsToolStripBtn As System.Windows.Forms.ToolStripButton
				Private pgWidthToolStripBtn As System.Windows.Forms.ToolStripButton
				Private windowToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private toolStripSeparator23 As System.Windows.Forms.ToolStripSeparator
				Private toolStripPanelItem43 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private viewToolStripBtn As System.Windows.Forms.ToolStripButton
				Private syncScrollToolStripBtn As System.Windows.Forms.ToolStripButton
				Private resetWindowPosToolStripBtn As System.Windows.Forms.ToolStripButton
				Private toolStripSeparator24 As System.Windows.Forms.ToolStripSeparator
				Private switchWindowsToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
				Private gridLayout1 As Syncfusion.Windows.Forms.Tools.GridLayout
				Private findToolStripBtn As System.Windows.Forms.ToolStripSplitButton
				Private findToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private goToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private themeColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private moreColorsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
				Private toolStripPanelItem44 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private tablefcontToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private markCitationToolStripBtn As System.Windows.Forms.ToolStripButton
				Private markEntryToolStripBtn As System.Windows.Forms.ToolStripButton
				Private rejectToolStripSplitButton As System.Windows.Forms.ToolStripSplitButton
				Private toolStripPanelItem45 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private nwWindowToolStripBtn As System.Windows.Forms.ToolStripButton
				Private arrangeAllToolStripBtn As System.Windows.Forms.ToolStripButton
				Private splitToolStripBtn As System.Windows.Forms.ToolStripButton
				Private toolStripPanelItem46 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private webLayoutToolStripBtn As System.Windows.Forms.ToolStripButton
				Private outlineToolStripBtn As System.Windows.Forms.ToolStripButton
				Private draftToolStripBtn As System.Windows.Forms.ToolStripButton
				Private dropCapToolStripSplitBtn As System.Windows.Forms.ToolStripDropDownButton
				Private orientationToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private sizeToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private morePaperSizesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private columnsToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private moreColumnsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private insertTableOfContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private removeTableOfContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
				Private doNotToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private level1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private level2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private level3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private inMergeFieldToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private finshMergeToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private turnOffTranslationTooltipToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
				Private rEjectAndMoveToNextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private rejectChangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private rejectAllChangesShownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private rejectAllChangesInDocumentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripEx6 As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private protectDocToolStripDropDownBtn As System.Windows.Forms.ToolStripDropDownButton
				Private restrictFormattingAndEditingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private unrestrictedAccessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private restrictedAccessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private toolStripSeparator26 As System.Windows.Forms.ToolStripSeparator
				Private manageCredentionalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private macrosToolStripEx As Syncfusion.Windows.Forms.Tools.ToolStripEx
				Private macrosToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
				Private viewMacrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private reToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private pauseMacroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
				Private lAlignToolStripBtn As System.Windows.Forms.ToolStripButton
				Private centerToolStripBtn As System.Windows.Forms.ToolStripButton
				Private rAlignToolStripBtn As System.Windows.Forms.ToolStripButton
				Private justifyToolStripBtn As System.Windows.Forms.ToolStripButton
				Private toolStripPanelItem9 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private sortToolStripBtn As System.Windows.Forms.ToolStripButton
				Private WithEvents toolStripPanelItem48 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
				Private WithEvents clearToolstripBtn As System.Windows.Forms.ToolStripButton
				Private toolStripPanelItem47 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private changecaseToolStripBtn As System.Windows.Forms.ToolStripDropDownButton
		Private progressTimer As System.Windows.Forms.Timer
		Private WithEvents blueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents silverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents blackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		'private System.Windows.Forms.ToolStripButton toolStripButton2;
		Private toolStripButton1 As System.Windows.Forms.ToolStripButton
		Private toolStripButton2 As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator27 As System.Windows.Forms.ToolStripSeparator
		Private toolStripSeparator28 As System.Windows.Forms.ToolStripSeparator
		Private officeSplitButton1 As Syncfusion.Windows.Forms.Tools.OfficeSplitButton
		Private officeDropDownButton3 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeDropDownButton4 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private toolStripButton3 As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator29 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents toolStripButton6 As System.Windows.Forms.ToolStripButton
		Private toolStripButton4 As System.Windows.Forms.ToolStripButton
		Private toolStripButton7 As System.Windows.Forms.ToolStripButton
		Private toolStripButton8 As System.Windows.Forms.ToolStripButton
		Private toolStripButton9 As System.Windows.Forms.ToolStripButton
		Private EditorContextMenuStripEx As Syncfusion.Windows.Forms.Tools.ContextMenuStripEx
		Private WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents toolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents toolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator30 As System.Windows.Forms.ToolStripSeparator
		Private toolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
		Private statusStripEx1 As Syncfusion.Windows.Forms.Tools.StatusStripEx
		Private trackBarItem1 As Syncfusion.Windows.Forms.Tools.TrackBarItem
		Private statusStripButton1 As Syncfusion.Windows.Forms.Tools.StatusStripButton
		Private statusStripButton2 As Syncfusion.Windows.Forms.Tools.StatusStripButton
		Private MiniToolBar As Syncfusion.Windows.Forms.Tools.MiniToolBar
		Private MiniToolBarPanelItem As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private PanelItem1 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private FontFaceCombo As System.Windows.Forms.ToolStripComboBox
		Private FontSize As System.Windows.Forms.ToolStripComboBox
		Private toolStripButton10 As System.Windows.Forms.ToolStripButton
		Private toolStripButton11 As System.Windows.Forms.ToolStripButton
		Private PanelItem2 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton12 As System.Windows.Forms.ToolStripButton
		Private toolStripButton13 As System.Windows.Forms.ToolStripButton
				Private toolStripButton14 As System.Windows.Forms.ToolStripButton
		Private toolStripButton15 As System.Windows.Forms.ToolStripButton
		Private toolStripButton16 As System.Windows.Forms.ToolStripButton
		Private toolStripButton17 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripGallery2 As Syncfusion.Windows.Forms.Tools.ToolStripGallery
		Private GalleryImages As System.Windows.Forms.ImageList
		Private toolStripButton18 As System.Windows.Forms.ToolStripButton
        Private statusStripButton4 As Syncfusion.Windows.Forms.Tools.StatusStripButton
		Private statusStripButton5 As Syncfusion.Windows.Forms.Tools.StatusStripButton
		Private officeDropDownButton1 As Syncfusion.Windows.Forms.Tools.OfficeDropDownButton
		Private officeSplitButton2 As Syncfusion.Windows.Forms.Tools.OfficeSplitButton
		Private toolStripButton5 As System.Windows.Forms.ToolStripButton
		Private toolStripButton19 As System.Windows.Forms.ToolStripButton
		Private toolStripButton20 As System.Windows.Forms.ToolStripButton
		Private toolStripButton21 As System.Windows.Forms.ToolStripButton
				Private toolStripButton22 As System.Windows.Forms.ToolStripButton
				Private officeButton1 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton2 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton3 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton4 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton5 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton6 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton7 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton8 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton9 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton10 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton11 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton12 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton13 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton14 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton15 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton16 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton17 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton18 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton19 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private officeButton20 As Syncfusion.Windows.Forms.Tools.OfficeButton
				Private toolStripSplitButton1 As System.Windows.Forms.ToolStripButton
        Private toolStripSplitButton2 As System.Windows.Forms.ToolStripButton
        Friend WithEvents rulerCheckBox As Syncfusion.Windows.Forms.Tools.ToolStripCheckBox
        Friend WithEvents gridlinesCheckBox2 As Syncfusion.Windows.Forms.Tools.ToolStripCheckBox
        Friend WithEvents msgBarCheckBox As Syncfusion.Windows.Forms.Tools.ToolStripCheckBox
        Friend WithEvents docMapCheckBox As Syncfusion.Windows.Forms.Tools.ToolStripCheckBox
        Friend WithEvents thumbNailsCheckBox As Syncfusion.Windows.Forms.Tools.ToolStripCheckBox
        Friend WithEvents SplashControl1 As Syncfusion.Windows.Forms.Tools.SplashControl
        Friend WithEvents SplashPanel1 As Syncfusion.Windows.Forms.Tools.SplashPanel
        Private WithEvents statusStripLabel1 As Syncfusion.Windows.Forms.Tools.StatusStripLabel
		End Class
End Namespace

