<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FFOutputForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FFMpegOutput = New System.Windows.Forms.TextBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FFMpegOutput
        '
        Me.FFMpegOutput.Location = New System.Drawing.Point(15, 15)
        Me.FFMpegOutput.Multiline = True
        Me.FFMpegOutput.Name = "FFMpegOutput"
        Me.FFMpegOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FFMpegOutput.Size = New System.Drawing.Size(760, 330)
        Me.FFMpegOutput.TabIndex = 0
        '
        'btnStop
        '
        Me.btnStop.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnStop.Location = New System.Drawing.Point(320, 360)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(140, 50)
        Me.btnStop.TabIndex = 102
        Me.btnStop.Text = "STOP"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'FFOutputForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 426)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.FFMpegOutput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FFOutputForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Probíhá konverze...."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FFMpegOutput As TextBox
    Friend WithEvents btnStop As Button
End Class
