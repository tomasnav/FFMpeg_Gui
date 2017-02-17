<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FFMpegLogForm
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
        Me.FFMpegLogInfo = New System.Windows.Forms.TextBox()
        Me.btnFFMpegLogFormZpet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FFMpegLogInfo
        '
        Me.FFMpegLogInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FFMpegLogInfo.Location = New System.Drawing.Point(15, 15)
        Me.FFMpegLogInfo.Multiline = True
        Me.FFMpegLogInfo.Name = "FFMpegLogInfo"
        Me.FFMpegLogInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FFMpegLogInfo.Size = New System.Drawing.Size(795, 440)
        Me.FFMpegLogInfo.TabIndex = 0
        '
        'btnFFMpegLogFormZpet
        '
        Me.btnFFMpegLogFormZpet.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnFFMpegLogFormZpet.Location = New System.Drawing.Point(330, 465)
        Me.btnFFMpegLogFormZpet.Name = "btnFFMpegLogFormZpet"
        Me.btnFFMpegLogFormZpet.Size = New System.Drawing.Size(140, 50)
        Me.btnFFMpegLogFormZpet.TabIndex = 51
        Me.btnFFMpegLogFormZpet.Text = "ZPĚT"
        Me.btnFFMpegLogFormZpet.UseVisualStyleBackColor = True
        '
        'FFMpegLogForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 531)
        Me.Controls.Add(Me.btnFFMpegLogFormZpet)
        Me.Controls.Add(Me.FFMpegLogInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FFMpegLogForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FFMpeg Log"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FFMpegLogInfo As TextBox
    Friend WithEvents btnFFMpegLogFormZpet As Button
End Class
