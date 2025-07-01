#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventTracer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.output = New Syncfusion.Windows.Forms.Grid.GridControl
        CType(Me.output, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'output
        '
        Me.output.Location = New System.Drawing.Point(2, 2)
        Me.output.Name = "output"
        Me.output.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
        Me.output.Size = New System.Drawing.Size(518, 147)
        Me.output.SmartSizeBox = False
        Me.output.TabIndex = 0
        Me.output.Text = "GridControl1"
        Me.output.UseRightToLeftCompatibleTextBox = True
        '
        'EventTracer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.output)
        Me.Name = "EventTracer"
        Me.Size = New System.Drawing.Size(521, 150)
        CType(Me.output, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents output As Syncfusion.Windows.Forms.Grid.GridControl

End Class
