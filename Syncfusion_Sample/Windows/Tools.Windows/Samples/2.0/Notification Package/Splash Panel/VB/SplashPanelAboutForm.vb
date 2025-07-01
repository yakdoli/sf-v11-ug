#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms

Namespace SplashPanelDemo
   
   
   Public Class SplashPanelAboutForm
      Inherits DemoCommon.AboutForm
      Private components As System.ComponentModel.IContainer = Nothing
      
      
      Public Sub New()
         ' This call is required by the Windows Form Designer.
         InitializeComponent()
      End Sub 'New
       
      ' TODO: Add any initialization after the InitializeComponent call
      
      Public Sub New(type As Type)
         MyBase.New(type)
         ' This call is required by the Windows Form Designer.
         InitializeComponent()
      End Sub 'New
       
      ' TODO: Add any initialization after the InitializeComponent call
      
      '/ <summary>
      '/ Clean up any resources being used.
      '/ </summary>
      Protected Overrides Sub Dispose(disposing As Boolean)
         If disposing Then
            If Not (components Is Nothing) Then
               components.Dispose()
            End If
         End If
         MyBase.Dispose(disposing)
      End Sub 'Dispose
      
      #Region "Designer generated code"
      
      '/ <summary>
      '/ Required method for Designer support - do not modify
      '/ the contents of this method with the code editor.
      '/ </summary>
      Private Sub InitializeComponent()
            Me.SuspendLayout()
          
            'SplashPanelAboutForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(442, 192)
            Me.MaximizeBox = False
            Me.Name = "SplashPanelAboutForm"
            Me.ResumeLayout(False)

        End Sub 'InitializeComponent 
      #End Region
   End Class 'SplashPanelAboutForm
End Namespace 'SplashPanelDemo
