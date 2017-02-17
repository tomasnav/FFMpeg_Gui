Imports System
Imports System.Text


Module FFMpeg
    Public FFMpegPID As Process
    Private FFMpegStartTime As DateTime
    Public FFMpegOutputLog As StringBuilder = New StringBuilder()
    Dim infoTextBox As TextBox

    Private showExtendedInfo As Boolean
    Private ffmpeginfo As New FFOutputForm
    Public ffmpeg_canceled As Boolean



    Sub startFFMpeg(arg As String, parShowExtendedInfo As Boolean)
        Dim process As New Process()

        showExtendedInfo = parShowExtendedInfo
        If showExtendedInfo Then
            ffmpeginfo.Height = 465
            ffmpeginfo.FFMpegOutput.Height = 330
            ffmpeginfo.FFMpegOutput.Multiline = True
            ffmpeginfo.btnStop.Location = New Point(320, 360)
        Else
            ffmpeginfo.Height = 165
            ffmpeginfo.FFMpegOutput.Height = 40
            ffmpeginfo.FFMpegOutput.Multiline = False
            ffmpeginfo.btnStop.Location = New Point(320, 60)
        End If
        process.StartInfo.FileName = FFMpegPath
        process.StartInfo.Arguments = arg

        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.CreateNoWindow = True
        process.EnableRaisingEvents = True

        infoTextBox = ffmpeginfo.FFMpegOutput

        AddHandler process.Exited, AddressOf FFMpegEnd
        AddHandler process.ErrorDataReceived, AddressOf FFMpegOutputHandler
        'AddHandler process.OutputDataReceived, AddressOf OutputHandler
        FFMpegPID = process

        FFMpegStartTime = DateTime.Now
        ffmpeg_canceled = False
        process.Start()

        ' Asynchronously read the standard output of the spawned process. 
        ' This raises OutputDataReceived events for each line of output.
        process.BeginErrorReadLine()
        'process.BeginOutputReadLine()        

        ffmpeginfo.ShowDialog()
    End Sub


    Sub FFMpegOutputHandler(sender As Object, e As DataReceivedEventArgs)
        If Not String.IsNullOrEmpty(e.Data) Then
            If infoTextBox.InvokeRequired = True Then
                infoTextBox.Invoke(myDelegate, e.Data)
            Else
                FFMpeg_UpdateTextBox(e.Data)
            End If
        End If
    End Sub

    Delegate Sub UpdateTextBoxDelg(text As String)
    Public myDelegate As UpdateTextBoxDelg = New UpdateTextBoxDelg(AddressOf FFMpeg_UpdateTextBox)

    Public Sub FFMpeg_UpdateTextBox(text As String)
        FFMpegOutputLog.Append(text).AppendLine()
        If showExtendedInfo Then
            infoTextBox.AppendText(text & Environment.NewLine)
        Else
            infoTextBox.Text = text
        End If
        infoTextBox.ScrollToCaret()
    End Sub

    Public Sub FFMpegEnd()
        FFMpegPID = Nothing
        Dim TotalTime As TimeSpan = DateTime.Now - FFMpegStartTime
        If ffmpeginfo.InvokeRequired Then
            ffmpeginfo.Invoke(New MethodInvoker(AddressOf FFMpegEnd))
            Exit Sub
        End If
        ffmpeginfo.Close()
        If ffmpeg_canceled Then
        Else
            MsgBox("Převod byl ukončen. Celkový čas převodu byl " + TotalTime.ToString("mm' minut a 'ss' sekund'"))
        End If

    End Sub



End Module