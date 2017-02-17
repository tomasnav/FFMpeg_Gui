Imports System.Web.Script.Serialization
Imports System
Imports System.IO
'Imports System.Diagnostics
'Imports System.ComponentModel
'Imports System.Windows.Forms
'Imports System.Text



Public Class MainForm
    Delegate Sub SetTextCallback([text] As String)

    Public FFProbeStreamInfo As String

    Sub setStreamInfo(videoFile As String)
        ' Set cursor as hourglass
        Cursor.Current = Cursors.WaitCursor
        Me.UseWaitCursor = True

        Dim jss As New JavaScriptSerializer()
        FFProbeStreamInfo = getStreamInfo(videoFile)

        streamInfo = jss.DeserializeObject(FFProbeStreamInfo)

        setControlInfo(streamInfo, Me.videoStreams, "video")
        setControlInfo(streamInfo, Me.audioStreams, "audio")
        setControlInfo(streamInfo, Me.subtitleStreams, "subtitle")
        Me.inpZacatek.Text = "0:00:00"
        setControlInfo(streamInfo, Me.inpKonec, "duration")

        ' Set cursor as default arrow
        Cursor.Current = Cursors.Default

        Me.UseWaitCursor = False
    End Sub

    Function setFFMpegPar()
        Dim argList As String = ""
        Dim poradi_streamu As Integer

        If (Me.inpZdroj.Text <> "") Then
            argList += " -hide_banner "

            If Not (Me.FFMpegFullInfo.Checked) Then
                argList += "-v quiet "
                argList += " -stats "
            End If

            argList += " -i " + (Me.inpZdroj.Text)
            '-threads 0 je stejne jako kdyz se neuvede
            'argList += " -threads 0"        
            'Overwrite output files without asking
            argList += " -y "
            'format
            argList += " -f " + (Me.inpFormat.Text)

            'video streams
            poradi_streamu = 0
            For Each jeden In Me.videoStreams.CheckedItems
                argList += " -map 0:" + jeden.Text + " -c:v:" + poradi_streamu.ToString + " " + Me.videoCodec.SelectedItem


                If Me.videoBitRate.SelectedIndex > 0 Then
                    argList += " -b:v:" + poradi_streamu.ToString + " " + Me.videoBitRate.SelectedItem
                End If

                'scale video          
                If Me.videoSize.SelectedIndex > 0 Then
                    argList += " -vf:v:" + poradi_streamu.ToString + " scale=" + Me.videoSize.SelectedItem + ":-1"
                End If

                'aspect video          
                If Me.videoAspectRatio.SelectedIndex > 0 Then
                    argList += " -aspect:v:" + poradi_streamu.ToString + " " + Me.videoAspectRatio.SelectedItem
                End If

                poradi_streamu += 1
            Next

            'audio
            poradi_streamu = 0
            For Each jeden In Me.audioStreams.CheckedItems
                argList += " -map 0:" + jeden.Text + " -c:a:" + poradi_streamu.ToString + " " + Me.audioCodec.SelectedItem

                If Me.audioBitRate.SelectedIndex > 0 Then
                    argList += " -b:a:" + poradi_streamu.ToString + " " + Me.audioBitRate.SelectedItem
                End If

                If Me.audioFrequency.SelectedIndex > 0 Then
                    argList += " -ar:a:" + poradi_streamu.ToString + " " + Me.audioFrequency.SelectedItem
                End If

                If Me.audioChannels.SelectedIndex > 0 Then
                    argList += " -ac:a:" + poradi_streamu.ToString + " " + Me.audioChannels.SelectedItem
                End If
                poradi_streamu += 1
            Next

            'subtitle
            poradi_streamu = 0
            For Each jeden In Me.subtitleStreams.CheckedItems
                argList += " -map 0:" + jeden.Text + " -c:s:" + poradi_streamu.ToString + " " + Me.subtitleCodec.SelectedItem
                poradi_streamu += 1
            Next

            argList += " -ss " + Me.inpZacatek.Text
            argList += " -to " + Me.inpKonec.Text
            argList += " " + Me.inpCil.Text
        End If

        Me.FFMpegCMD.Text = argList
        Return argList
    End Function

    Private Sub nastavZdroj(zdroj As String)
        Me.inpZdroj.Text = zdroj
        Me.videoPlayer.input.rate = 4
        Me.videoPlayer.playlist.add("file:///" & Me.inpZdroj.Text)
        'Me.videoPlayer.playlist.play()

        setStreamInfo(zdroj)
        setFFMpegPar()
        Me.btnShowFFMpegLog.Enabled = False
        Me.btnFFProbeInfo.Enabled = True
        Me.btnStart.Enabled = True
    End Sub

    Private Sub btnVyberZdroje_Click(sender As Object, e As EventArgs) Handles btnVyberZdroje.Click
        Dim otevreniSouboru As New OpenFileDialog()

        otevreniSouboru.Filter = "Video soubory|*.ts;*.mkv;*.avi;*.mp4|Všechny soubory (*.*)|*.*"
        otevreniSouboru.Title = "Výběr video souboru"

        If otevreniSouboru.ShowDialog() = MsgBoxResult.Ok Then
            nastavZdroj(otevreniSouboru.FileName)
        End If
    End Sub
    Private Function getMediaPlayerPosition()


        Dim iSpan As TimeSpan = TimeSpan.FromMilliseconds(videoPlayer.input.time)
        Dim mydate As DateTime = New DateTime(iSpan.Ticks)
        Return mydate.ToString(("HH:mm:ss"))
    End Function

    Private Sub inpZacatek_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles inpZacatek.MouseDoubleClick
        Me.inpZacatek.Text = getMediaPlayerPosition()
    End Sub

    Private Sub inpZacatek_TextChanged(sender As Object, e As EventArgs) Handles inpZacatek.TextChanged
        setFFMpegPar()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.videoPlayer.settings.autoStart = False

        Me.videoStreams.Columns.Add("index", 40, HorizontalAlignment.Center)
        Me.videoStreams.Columns.Add("kodek", 75, HorizontalAlignment.Center)
        Me.videoStreams.Columns.Add("rozlišení", 95, HorizontalAlignment.Center)

        Me.audioStreams.Columns.Add("index", 40, HorizontalAlignment.Center)
        Me.audioStreams.Columns.Add("kodek", 55, HorizontalAlignment.Center)
        Me.audioStreams.Columns.Add("bitrate", 55, HorizontalAlignment.Center)
        Me.audioStreams.Columns.Add("frekvence", 55, HorizontalAlignment.Center)
        Me.audioStreams.Columns.Add("jazyk", 70, HorizontalAlignment.Center)
        Me.audioStreams.Columns.Add("kanály", 45, HorizontalAlignment.Center)

        Me.subtitleStreams.Columns.Add("index", 40, HorizontalAlignment.Center)
        Me.subtitleStreams.Columns.Add("kodek", 110, HorizontalAlignment.Center)
        Me.subtitleStreams.Columns.Add("jazyk", 115, HorizontalAlignment.Center)

        Me.inpFormat.Items.AddRange(allowedOutputFormat)
        Me.inpFormat.Text = allowedOutputFormat(defaultOutputFormat)
        Me.inpZacatek.Text = "0:00:00"
        Me.inpKonec.Text = "0:00:00"

        'Me.inpFFProbePath.Text = FFProbePath
        'Me.inpFFMpegPath.Text = FFMpegPath
        Me.inpFFProbePath.Text = My.Settings.FFProbePath
        Me.inpFFMpegPath.Text = My.Settings.FFMpegPath

        Me.videoCodec.Items.AddRange(allowedVideoCodec)
        Me.videoCodec.Text = allowedVideoCodec(DefaultVideoCodec)

        Me.videoBitRate.Items.AddRange(allowedVideoBitRate)
        Me.videoBitRate.Text = allowedVideoBitRate(DefaultVideoBitRate)

        Me.videoSize.Items.AddRange(allowedVideoSize)
        Me.videoSize.Text = allowedVideoSize(0)

        Me.videoAspectRatio.Items.AddRange(allowedVideoAspectRatio)
        Me.videoAspectRatio.Text = allowedVideoAspectRatio(0)

        Me.audioCodec.Items.AddRange(allowedAudioCodec)
        Me.audioCodec.Text = allowedAudioCodec(0)

        Me.audioChannels.Items.AddRange(allowedAudioChannels)
        Me.audioChannels.Text = allowedAudioChannels(0)

        Me.audioFrequency.Items.AddRange(allowedAudioFrequency)
        Me.audioFrequency.Text = allowedAudioFrequency(0)

        Me.audioBitRate.Items.AddRange(allowedAudioBitRate)
        Me.audioBitRate.Text = allowedAudioBitRate(DefaultAudioBitRate)

        Me.audioCodec.Items.AddRange(allowedAudioCodec)
        Me.audioCodec.Text = allowedAudioCodec(DefaultAudioCodec)

        Me.subtitleCodec.Items.AddRange(allowedSubtitleCodec)
        Me.subtitleCodec.Text = allowedSubtitleCodec(0)

        Me.btnShowFFMpegLog.Enabled = False
        Me.btnFFProbeInfo.Enabled = False
        Me.btnStart.Enabled = False

        ' test only
        'Me.inpZdroj.Text = "c:\mkv\pustina_1.ts"
        'Me.inpCil.Text = "c:\mkv\pokus.mkv"
        'nastavZdroj(Me.inpZdroj.Text)
        'Me.inpKonec.Text = "0:00:10"
        ' test only

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        videoPlayer.playlist.stop()

        If Me.inpCil.Text <> "" Then
            If IsValidFileName(Me.inpCil.Text) Then
                Me.btnShowFFMpegLog.Enabled = True
                FFMpegPID = Nothing

                'startFFMpeg(setFFMpegPar(), DirectCast((pokus2.Controls.Find("FFMpegLogInfo", True)), System.Windows.Forms.Control())(0))
                startFFMpeg(setFFMpegPar(), FFMpegFullInfo.Checked)
            Else
                MsgBox("Musíte zadat platné jméno výstupního souboru!", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Musíte zadat platné jméno výstupního souboru!", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub btnSetEnd_Click(sender As Object, e As EventArgs) Handles btnSetEnd.Click
        Me.inpKonec.Text = getMediaPlayerPosition()
    End Sub

    Private Sub btnZpet_Click(sender As Object, e As EventArgs) Handles btnZpet.Click
        If AnoNe("Opravdu chcete skončit?") Then
            Me.Close()
        End If
    End Sub

    Private Sub FFMpegFullInfo_CheckedChanged(sender As Object, e As EventArgs) Handles FFMpegFullInfo.CheckedChanged
        setFFMpegPar()
    End Sub

    Private Sub inpFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles inpFormat.SelectedIndexChanged
        setFFMpegPar()
    End Sub

    Private Sub inpKonec_TextChanged(sender As Object, e As EventArgs) Handles inpKonec.TextChanged
        setFFMpegPar()
    End Sub

    Private Sub videoCodec_SelectedValueChanged(sender As Object, e As EventArgs) Handles videoCodec.SelectedValueChanged
        setFFMpegPar()
    End Sub

    Private Sub videoBitRate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles videoBitRate.SelectedIndexChanged
        setFFMpegPar()
    End Sub

    Private Sub videoSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles videoSize.SelectedIndexChanged
        setFFMpegPar()
    End Sub

    Private Sub videoAspectRatio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles videoAspectRatio.SelectedIndexChanged
        setFFMpegPar()
    End Sub

    Private Sub audioCodec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles audioCodec.SelectedIndexChanged
        setFFMpegPar()
    End Sub

    Private Sub audioBitRate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles audioBitRate.SelectedIndexChanged
        setFFMpegPar()
    End Sub

    Private Sub audioFrequency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles audioFrequency.SelectedIndexChanged
        setFFMpegPar()
    End Sub

    Private Sub audioChannels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles audioChannels.SelectedIndexChanged
        setFFMpegPar()
    End Sub

    Private Sub subtitleCodec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subtitleCodec.SelectedIndexChanged
        setFFMpegPar()
    End Sub

    Private Sub videoStreams_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles videoStreams.ItemChecked
        setFFMpegPar()
    End Sub

    Private Sub audioStreams_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles audioStreams.ItemChecked
        setFFMpegPar()
    End Sub

    Private Sub subtitleStreams_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles subtitleStreams.ItemChecked
        setFFMpegPar()
    End Sub

    Private Sub inpKonec_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles inpKonec.MouseDoubleClick
        Me.inpKonec.Text = getMediaPlayerPosition()
    End Sub

    Private Sub btnSetStart_Click(sender As Object, e As EventArgs) Handles btnSetStart.Click
        Me.inpZacatek.Text = getMediaPlayerPosition()
    End Sub

    Private Sub btnShowFFMpegLog_Click(sender As Object, e As EventArgs) Handles btnShowFFMpegLog.Click
        If (FFMpegPID Is Nothing) Then
            logForm.FFMpegLogInfo.Text = FFMpegOutputLog.ToString
            logForm.Text = "FFMpeg log"
            logForm.ShowDialog()
        End If

    End Sub



    Private Sub btnVyberCile_Click(sender As Object, e As EventArgs) Handles btnVyberCile.Click
        Dim vyberSouboru As New SaveFileDialog()

        vyberSouboru.Filter = "Všechny soubory (*.*)|*.*"
        vyberSouboru.Title = "Výstupní soubor"

        If vyberSouboru.ShowDialog() = MsgBoxResult.Ok Then
            Me.inpCil.Text = vyberSouboru.FileName
        End If
    End Sub

    Private Sub btnFFProbeInfo_Click(sender As Object, e As EventArgs) Handles btnFFProbeInfo.Click
        If (FFMpegPID Is Nothing) Then
            logForm.FFMpegLogInfo.Text = FFProbeStreamInfo.ToString
            logForm.Text = "FFProbe log"
            logForm.ShowDialog()
        End If
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not AnoNe("Opravdu chcete skončit?")
    End Sub

    Private Sub btnVyberFFProbe_Click(sender As Object, e As EventArgs) Handles btnVyberFFProbe.Click
        Dim otevreniSouboru As New OpenFileDialog()

        otevreniSouboru.Filter = "EXE soubor|*.exe"
        otevreniSouboru.Title = "Umístění programu FFProbe"

        If otevreniSouboru.ShowDialog() = MsgBoxResult.Ok Then
            Me.inpFFProbePath.Text = otevreniSouboru.FileName
            My.Settings.FFProbePath = otevreniSouboru.FileName
            My.Settings.Save()
        End If

    End Sub

    Private Sub btnVyberFFMpeg_Click(sender As Object, e As EventArgs) Handles btnVyberFFMpeg.Click
        Dim otevreniSouboru As New OpenFileDialog()

        otevreniSouboru.Filter = "EXE soubor|*.exe"
        otevreniSouboru.Title = "Umístění programu FFMpeg"

        If otevreniSouboru.ShowDialog() = MsgBoxResult.Ok Then
            Me.inpFFMpegPath.Text = otevreniSouboru.FileName
            My.Settings.FFMpegPath = otevreniSouboru.FileName
            My.Settings.Save()
        End If
    End Sub
End Class

