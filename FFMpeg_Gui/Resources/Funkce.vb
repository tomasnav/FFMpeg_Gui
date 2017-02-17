Imports System.Web.Script.Serialization
Imports System.Globalization
Imports System.IO


Module Funkce
    Function AnoNe(msg As String, Optional ByVal msgTitle As String = "Dotaz")
        Dim style = MsgBoxStyle.YesNo
        Dim retVal = MsgBox(msg, style, msgTitle)
        Return retVal = MsgBoxResult.Yes
    End Function


    Function getStreamInfo(videoFile As String)
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo(FFProbePath, FFProbeParam & Chr(34) & videoFile & Chr(34))

        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oStartInfo.CreateNoWindow = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()

        Dim json As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            json = oStreamReader.ReadToEnd()
        End Using


        Return json
    End Function

    Sub setControlInfo(ByRef streamInfo As Object, ByRef inputCtl As Control, typ As String)
        Dim jedenStream As Object

        If (typ = "video") Or (typ = "audio") Or (typ = "subtitle") Then
            Dim seznamPrvku As New List(Of ListViewItem)
            Dim jedenPrvek As ListViewItem

            For index = 0 To streamInfo.Item("streams").GetUpperBound(0)
                jedenStream = streamInfo.Item("streams")(index)
                If jedenStream.ContainsKey("codec_type") Then
                    If jedenStream.Item("codec_type") = typ Then

                        jedenPrvek = New ListViewItem(jedenStream.Item("index").ToString, 0)

                        jedenPrvek.SubItems.Add(jedenStream.Item("codec_name"))
                        Select Case typ
                            Case "video"
                                jedenPrvek.Checked = True
                                jedenPrvek.SubItems.Add(jedenStream.Item("width").ToString + " x " + jedenStream.Item("height").ToString)

                            Case "audio"
                                If jedenStream.ContainsKey("sample_rate") Then
                                    jedenPrvek.SubItems.Add(jedenStream.Item("sample_rate"))
                                Else
                                    jedenPrvek.SubItems.Add("N/A")
                                End If

                                Dim value As String = ""
                                If jedenStream.ContainsKey("bit_rate") Then
                                    jedenPrvek.SubItems.Add(Math.Round(jedenStream.Item("bit_rate") / 1024).ToString + " kb")
                                Else
                                    jedenPrvek.SubItems.Add("N/A")
                                End If

                                Dim jazyk As String
                                If jedenStream.ContainsKey("tags") Then
                                    If jedenStream.Item("tags").ContainsKey("language") Then
                                        jazyk = jedenStream.Item("tags").item("language")
                                        jedenPrvek.SubItems.Add(jazyk)
                                        jedenPrvek.Checked = jazyk.ToLower().Contains("cze") Or jazyk.ToLower().Contains("slo")
                                    Else
                                        jedenPrvek.SubItems.Add("N/A")
                                    End If
                                Else
                                    jedenPrvek.SubItems.Add("N/A")
                                End If


                                If jedenStream.ContainsKey("channels") Then
                                    jedenPrvek.SubItems.Add(jedenStream.Item("channels"))
                                Else
                                    jedenPrvek.SubItems.Add("N/A")
                                End If
                            Case "subtitle"
                                If jedenStream.ContainsKey("tags") Then
                                    If jedenStream.Item("tags").ContainsKey("language") Then
                                        jedenPrvek.SubItems.Add(jedenStream.Item("tags").item("language"))
                                    Else
                                        jedenPrvek.SubItems.Add("N/A")
                                    End If
                                Else
                                    jedenPrvek.SubItems.Add("N/A")
                                End If



                        End Select

                        seznamPrvku.Add(jedenPrvek)
                    End If
                End If
            Next

            Dim seznam As ListView = inputCtl
            seznam.Items.Clear()
            seznam.Items.AddRange(seznamPrvku.ToArray)

        ElseIf typ = "duration" Then
            Dim delka_videa = 0
            Dim inpBox As TextBox = inputCtl
            Dim style As NumberStyles = NumberStyles.Number
            Dim provider As CultureInfo = New CultureInfo("en-US")

            For index = 0 To streamInfo.Item("streams").GetUpperBound(0)
                jedenStream = streamInfo.Item("streams")(index)
                If jedenStream.ContainsKey("codec_type") Then
                    If jedenStream.Item("codec_type") = "video" Then
                        If jedenStream.ContainsKey("duration") Then
                            delka_videa = Decimal.Parse(jedenStream.Item("duration"), style, provider)
                        Else
                            jedenStream = streamInfo.Item("format")
                            If jedenStream.ContainsKey("duration") Then
                                delka_videa = Decimal.Parse(jedenStream.Item("duration"), style, provider)
                            End If
                        End If
                        Dim ts As TimeSpan = TimeSpan.FromSeconds(delka_videa)
                        Dim dt As DateTime = New DateTime(ts.Ticks)

                        inpBox.Text = dt.ToString(("HH:mm:ss"))
                    End If
                End If
            Next
        End If

    End Sub

    'Public Function FilenameIsOK(ByVal fileName As String) As Boolean
    '    Dim file As String = Path.GetFileName(fileName)
    '    Dim directory As String = Path.GetDirectoryName(fileName)

    '    Return Not (file.Intersect(Path.GetInvalidFileNameChars()).Any() _
    '                OrElse
    '                directory.Intersect(Path.GetInvalidPathChars()).Any())
    'End Function

    Public Function FilenameIsOK(ByVal fileNameAndPath As String) As Boolean
        Dim fileName = Path.GetFileName(fileNameAndPath)
        Dim directory = Path.GetDirectoryName(fileNameAndPath)
        For Each c In Path.GetInvalidFileNameChars()
            If fileName.Contains(c) Then
                Return False
            End If
        Next
        For Each c In Path.GetInvalidPathChars()
            If directory.Contains(c) Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Function IsValidFileName(ByVal fn As String) As Boolean
        Try
            Dim fi As New IO.FileInfo(fn)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

End Module
