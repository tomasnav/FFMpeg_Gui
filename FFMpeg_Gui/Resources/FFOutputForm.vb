Public Class FFOutputForm
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If AnoNe("Opravdu ukončit probíhající převod?") Then
            ffmpeg_canceled = True
            If FFMpegPID IsNot Nothing Then FFMpegPID.Kill()
        End If
    End Sub
End Class