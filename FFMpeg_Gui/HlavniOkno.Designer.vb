<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inpZdroj = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inpZacatek = New System.Windows.Forms.TextBox()
        Me.inpKonec = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnVyberCile = New System.Windows.Forms.Button()
        Me.inpCil = New System.Windows.Forms.TextBox()
        Me.inpFormat = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnVyberFFProbe = New System.Windows.Forms.Button()
        Me.inpFFProbePath = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnVyberFFMpeg = New System.Windows.Forms.Button()
        Me.inpFFMpegPath = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FFMpegCMD = New System.Windows.Forms.TextBox()
        Me.videoStreams = New System.Windows.Forms.ListView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.videoCodec = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.videoBitRate = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.videoSize = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.videoAspectRatio = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.subtitleCodec = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.audioChannels = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.audioFrequency = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.audioBitRate = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.audioCodec = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnZpet = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnVyberZdroje = New System.Windows.Forms.Button()
        Me.btnSetStart = New System.Windows.Forms.Button()
        Me.btnSetEnd = New System.Windows.Forms.Button()
        Me.audioStreams = New System.Windows.Forms.ListView()
        Me.subtitleStreams = New System.Windows.Forms.ListView()
        Me.FFMpegFullInfo = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnShowFFMpegLog = New System.Windows.Forms.Button()
        Me.btnFFProbeInfo = New System.Windows.Forms.Button()
        Me.videoPlayer = New AxAXVLC.AxVLCPlugin2()
        CType(Me.videoPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Zdroj:"
        '
        'inpZdroj
        '
        Me.inpZdroj.Enabled = False
        Me.inpZdroj.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.inpZdroj.Location = New System.Drawing.Point(80, 20)
        Me.inpZdroj.Name = "inpZdroj"
        Me.inpZdroj.Size = New System.Drawing.Size(490, 23)
        Me.inpZdroj.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Začátek:"
        '
        'inpZacatek
        '
        Me.inpZacatek.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.inpZacatek.Location = New System.Drawing.Point(260, 100)
        Me.inpZacatek.Name = "inpZacatek"
        Me.inpZacatek.Size = New System.Drawing.Size(80, 23)
        Me.inpZacatek.TabIndex = 6
        Me.inpZacatek.Text = "1:15:25"
        Me.ToolTip1.SetToolTip(Me.inpZacatek, "Dvojklik nastaví na aktuální pozici přehrávače")
        '
        'inpKonec
        '
        Me.inpKonec.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.inpKonec.Location = New System.Drawing.Point(435, 100)
        Me.inpKonec.Name = "inpKonec"
        Me.inpKonec.Size = New System.Drawing.Size(66, 23)
        Me.inpKonec.TabIndex = 7
        Me.inpKonec.Text = "1:15:25"
        Me.ToolTip1.SetToolTip(Me.inpKonec, "Dvojklik nastaví na aktuální pozici přehrávače")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(375, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Konec:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Formát:"
        '
        'btnVyberCile
        '
        Me.btnVyberCile.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnVyberCile.Location = New System.Drawing.Point(570, 60)
        Me.btnVyberCile.Name = "btnVyberCile"
        Me.btnVyberCile.Size = New System.Drawing.Size(34, 23)
        Me.btnVyberCile.TabIndex = 4
        Me.btnVyberCile.Text = "..."
        Me.btnVyberCile.UseVisualStyleBackColor = True
        '
        'inpCil
        '
        Me.inpCil.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.inpCil.Location = New System.Drawing.Point(80, 60)
        Me.inpCil.Name = "inpCil"
        Me.inpCil.Size = New System.Drawing.Size(490, 23)
        Me.inpCil.TabIndex = 3
        '
        'inpFormat
        '
        Me.inpFormat.FormattingEnabled = True
        Me.inpFormat.Location = New System.Drawing.Point(80, 100)
        Me.inpFormat.Name = "inpFormat"
        Me.inpFormat.Size = New System.Drawing.Size(100, 21)
        Me.inpFormat.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Cíl:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "FFProbe:"
        '
        'btnVyberFFProbe
        '
        Me.btnVyberFFProbe.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnVyberFFProbe.Location = New System.Drawing.Point(570, 140)
        Me.btnVyberFFProbe.Name = "btnVyberFFProbe"
        Me.btnVyberFFProbe.Size = New System.Drawing.Size(34, 23)
        Me.btnVyberFFProbe.TabIndex = 9
        Me.btnVyberFFProbe.Text = "..."
        Me.btnVyberFFProbe.UseVisualStyleBackColor = True
        '
        'inpFFProbePath
        '
        Me.inpFFProbePath.Enabled = False
        Me.inpFFProbePath.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.inpFFProbePath.Location = New System.Drawing.Point(80, 140)
        Me.inpFFProbePath.Name = "inpFFProbePath"
        Me.inpFFProbePath.Size = New System.Drawing.Size(490, 23)
        Me.inpFFProbePath.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "FFMpeg:"
        '
        'btnVyberFFMpeg
        '
        Me.btnVyberFFMpeg.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnVyberFFMpeg.Location = New System.Drawing.Point(570, 180)
        Me.btnVyberFFMpeg.Name = "btnVyberFFMpeg"
        Me.btnVyberFFMpeg.Size = New System.Drawing.Size(34, 23)
        Me.btnVyberFFMpeg.TabIndex = 11
        Me.btnVyberFFMpeg.Text = "..."
        Me.btnVyberFFMpeg.UseVisualStyleBackColor = True
        '
        'inpFFMpegPath
        '
        Me.inpFFMpegPath.Enabled = False
        Me.inpFFMpegPath.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.inpFFMpegPath.Location = New System.Drawing.Point(80, 180)
        Me.inpFFMpegPath.Name = "inpFFMpegPath"
        Me.inpFFMpegPath.Size = New System.Drawing.Size(490, 23)
        Me.inpFFMpegPath.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Příkaz:"
        '
        'FFMpegCMD
        '
        Me.FFMpegCMD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FFMpegCMD.Location = New System.Drawing.Point(80, 240)
        Me.FFMpegCMD.Multiline = True
        Me.FFMpegCMD.Name = "FFMpegCMD"
        Me.FFMpegCMD.Size = New System.Drawing.Size(490, 105)
        Me.FFMpegCMD.TabIndex = 98
        Me.FFMpegCMD.TabStop = False
        '
        'videoStreams
        '
        Me.videoStreams.CheckBoxes = True
        Me.videoStreams.GridLines = True
        Me.videoStreams.Location = New System.Drawing.Point(80, 405)
        Me.videoStreams.Name = "videoStreams"
        Me.videoStreams.Size = New System.Drawing.Size(320, 100)
        Me.videoStreams.TabIndex = 13
        Me.videoStreams.UseCompatibleStateImageBehavior = False
        Me.videoStreams.View = System.Windows.Forms.View.Details
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(70, 375)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(320, 20)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Video"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.Location = New System.Drawing.Point(470, 375)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(350, 20)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Audio"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.Location = New System.Drawing.Point(900, 375)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(320, 20)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Titulky"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'videoCodec
        '
        Me.videoCodec.FormattingEnabled = True
        Me.videoCodec.Location = New System.Drawing.Point(150, 515)
        Me.videoCodec.Name = "videoCodec"
        Me.videoCodec.Size = New System.Drawing.Size(250, 21)
        Me.videoCodec.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.Location = New System.Drawing.Point(80, 515)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 15)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Kodek:"
        '
        'videoBitRate
        '
        Me.videoBitRate.FormattingEnabled = True
        Me.videoBitRate.Location = New System.Drawing.Point(150, 545)
        Me.videoBitRate.Name = "videoBitRate"
        Me.videoBitRate.Size = New System.Drawing.Size(250, 21)
        Me.videoBitRate.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(80, 545)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 15)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Bitrate:"
        '
        'videoSize
        '
        Me.videoSize.FormattingEnabled = True
        Me.videoSize.Location = New System.Drawing.Point(150, 575)
        Me.videoSize.Name = "videoSize"
        Me.videoSize.Size = New System.Drawing.Size(250, 21)
        Me.videoSize.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.Location = New System.Drawing.Point(80, 575)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 15)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Velikost:"
        '
        'videoAspectRatio
        '
        Me.videoAspectRatio.FormattingEnabled = True
        Me.videoAspectRatio.Location = New System.Drawing.Point(150, 605)
        Me.videoAspectRatio.Name = "videoAspectRatio"
        Me.videoAspectRatio.Size = New System.Drawing.Size(250, 21)
        Me.videoAspectRatio.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.Location = New System.Drawing.Point(80, 605)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 15)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Aspekt:"
        '
        'subtitleCodec
        '
        Me.subtitleCodec.FormattingEnabled = True
        Me.subtitleCodec.Location = New System.Drawing.Point(970, 515)
        Me.subtitleCodec.Name = "subtitleCodec"
        Me.subtitleCodec.Size = New System.Drawing.Size(250, 21)
        Me.subtitleCodec.TabIndex = 24
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.Location = New System.Drawing.Point(900, 515)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 15)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Kodek:"
        '
        'audioChannels
        '
        Me.audioChannels.FormattingEnabled = True
        Me.audioChannels.Location = New System.Drawing.Point(540, 605)
        Me.audioChannels.Name = "audioChannels"
        Me.audioChannels.Size = New System.Drawing.Size(280, 21)
        Me.audioChannels.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label17.Location = New System.Drawing.Point(470, 605)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 15)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Kanály:"
        '
        'audioFrequency
        '
        Me.audioFrequency.FormattingEnabled = True
        Me.audioFrequency.Location = New System.Drawing.Point(540, 575)
        Me.audioFrequency.Name = "audioFrequency"
        Me.audioFrequency.Size = New System.Drawing.Size(280, 21)
        Me.audioFrequency.TabIndex = 21
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label18.Location = New System.Drawing.Point(470, 575)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 15)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Frekvence:"
        '
        'audioBitRate
        '
        Me.audioBitRate.FormattingEnabled = True
        Me.audioBitRate.Location = New System.Drawing.Point(540, 545)
        Me.audioBitRate.Name = "audioBitRate"
        Me.audioBitRate.Size = New System.Drawing.Size(280, 21)
        Me.audioBitRate.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label19.Location = New System.Drawing.Point(470, 545)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 15)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Bitrate:"
        '
        'audioCodec
        '
        Me.audioCodec.FormattingEnabled = True
        Me.audioCodec.Location = New System.Drawing.Point(540, 515)
        Me.audioCodec.Name = "audioCodec"
        Me.audioCodec.Size = New System.Drawing.Size(280, 21)
        Me.audioCodec.TabIndex = 19
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label20.Location = New System.Drawing.Point(470, 515)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 15)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Kodek:"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnStart.Location = New System.Drawing.Point(10, 655)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(140, 50)
        Me.btnStart.TabIndex = 100
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnZpet
        '
        Me.btnZpet.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnZpet.Location = New System.Drawing.Point(1080, 655)
        Me.btnZpet.Name = "btnZpet"
        Me.btnZpet.Size = New System.Drawing.Size(140, 50)
        Me.btnZpet.TabIndex = 130
        Me.btnZpet.Text = "Zpět"
        Me.btnZpet.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Location = New System.Drawing.Point(10, 365)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(1210, 2)
        Me.Label21.TabIndex = 48
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Location = New System.Drawing.Point(10, 645)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(1210, 2)
        Me.Label22.TabIndex = 49
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Location = New System.Drawing.Point(430, 375)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(2, 260)
        Me.Label23.TabIndex = 50
        Me.Label23.Text = "Label23"
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Location = New System.Drawing.Point(860, 375)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(2, 260)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Label24"
        '
        'btnVyberZdroje
        '
        Me.btnVyberZdroje.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnVyberZdroje.Location = New System.Drawing.Point(570, 20)
        Me.btnVyberZdroje.Margin = New System.Windows.Forms.Padding(0)
        Me.btnVyberZdroje.Name = "btnVyberZdroje"
        Me.btnVyberZdroje.Size = New System.Drawing.Size(34, 23)
        Me.btnVyberZdroje.TabIndex = 2
        Me.btnVyberZdroje.Text = "..."
        Me.btnVyberZdroje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVyberZdroje.UseVisualStyleBackColor = True
        '
        'btnSetStart
        '
        Me.btnSetStart.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetStart.Location = New System.Drawing.Point(345, 100)
        Me.btnSetStart.Name = "btnSetStart"
        Me.btnSetStart.Size = New System.Drawing.Size(20, 23)
        Me.btnSetStart.TabIndex = 52
        Me.btnSetStart.TabStop = False
        Me.btnSetStart.Text = "["
        Me.ToolTip1.SetToolTip(Me.btnSetStart, "Nastaví začátek na aktuální pozici přehrávače")
        Me.btnSetStart.UseVisualStyleBackColor = True
        '
        'btnSetEnd
        '
        Me.btnSetEnd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSetEnd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetEnd.Location = New System.Drawing.Point(505, 100)
        Me.btnSetEnd.Name = "btnSetEnd"
        Me.btnSetEnd.Size = New System.Drawing.Size(20, 23)
        Me.btnSetEnd.TabIndex = 53
        Me.btnSetEnd.TabStop = False
        Me.btnSetEnd.Text = "]"
        Me.ToolTip1.SetToolTip(Me.btnSetEnd, "Nastaví konec na aktuální pozici přehrávače")
        Me.btnSetEnd.UseVisualStyleBackColor = True
        '
        'audioStreams
        '
        Me.audioStreams.CheckBoxes = True
        Me.audioStreams.GridLines = True
        Me.audioStreams.Location = New System.Drawing.Point(470, 405)
        Me.audioStreams.Name = "audioStreams"
        Me.audioStreams.Size = New System.Drawing.Size(350, 100)
        Me.audioStreams.TabIndex = 18
        Me.audioStreams.UseCompatibleStateImageBehavior = False
        Me.audioStreams.View = System.Windows.Forms.View.Details
        '
        'subtitleStreams
        '
        Me.subtitleStreams.CheckBoxes = True
        Me.subtitleStreams.GridLines = True
        Me.subtitleStreams.Location = New System.Drawing.Point(900, 405)
        Me.subtitleStreams.Name = "subtitleStreams"
        Me.subtitleStreams.Size = New System.Drawing.Size(320, 100)
        Me.subtitleStreams.TabIndex = 23
        Me.subtitleStreams.UseCompatibleStateImageBehavior = False
        Me.subtitleStreams.View = System.Windows.Forms.View.Details
        '
        'FFMpegFullInfo
        '
        Me.FFMpegFullInfo.AutoSize = True
        Me.FFMpegFullInfo.Location = New System.Drawing.Point(80, 215)
        Me.FFMpegFullInfo.Name = "FFMpegFullInfo"
        Me.FFMpegFullInfo.Size = New System.Drawing.Size(96, 17)
        Me.FFMpegFullInfo.TabIndex = 12
        Me.FFMpegFullInfo.Text = "Rozšířené info"
        Me.FFMpegFullInfo.UseVisualStyleBackColor = True
        '
        'btnShowFFMpegLog
        '
        Me.btnShowFFMpegLog.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnShowFFMpegLog.Location = New System.Drawing.Point(390, 655)
        Me.btnShowFFMpegLog.Name = "btnShowFFMpegLog"
        Me.btnShowFFMpegLog.Size = New System.Drawing.Size(140, 50)
        Me.btnShowFFMpegLog.TabIndex = 120
        Me.btnShowFFMpegLog.Text = "LOG"
        Me.btnShowFFMpegLog.UseVisualStyleBackColor = True
        '
        'btnFFProbeInfo
        '
        Me.btnFFProbeInfo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnFFProbeInfo.Location = New System.Drawing.Point(230, 655)
        Me.btnFFProbeInfo.Name = "btnFFProbeInfo"
        Me.btnFFProbeInfo.Size = New System.Drawing.Size(140, 50)
        Me.btnFFProbeInfo.TabIndex = 110
        Me.btnFFProbeInfo.Text = "FFProbe"
        Me.btnFFProbeInfo.UseVisualStyleBackColor = True
        '
        'videoPlayer
        '
        Me.videoPlayer.Enabled = True
        Me.videoPlayer.Location = New System.Drawing.Point(620, 20)
        Me.videoPlayer.Name = "videoPlayer"
        Me.videoPlayer.OcxState = CType(resources.GetObject("videoPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.videoPlayer.Size = New System.Drawing.Size(600, 340)
        Me.videoPlayer.TabIndex = 131
        Me.videoPlayer.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1234, 718)
        Me.Controls.Add(Me.videoPlayer)
        Me.Controls.Add(Me.btnFFProbeInfo)
        Me.Controls.Add(Me.btnShowFFMpegLog)
        Me.Controls.Add(Me.FFMpegFullInfo)
        Me.Controls.Add(Me.subtitleStreams)
        Me.Controls.Add(Me.audioStreams)
        Me.Controls.Add(Me.btnSetEnd)
        Me.Controls.Add(Me.btnSetStart)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btnZpet)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.audioChannels)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.audioFrequency)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.audioBitRate)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.audioCodec)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.subtitleCodec)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.videoAspectRatio)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.videoSize)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.videoBitRate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.videoCodec)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.videoStreams)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.FFMpegCMD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnVyberFFMpeg)
        Me.Controls.Add(Me.inpFFMpegPath)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnVyberFFProbe)
        Me.Controls.Add(Me.inpFFProbePath)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.inpFormat)
        Me.Controls.Add(Me.btnVyberCile)
        Me.Controls.Add(Me.inpCil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.inpKonec)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inpZacatek)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVyberZdroje)
        Me.Controls.Add(Me.inpZdroj)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.RightToLeftLayout = True
        Me.Text = "FFMpeg GUI"
        CType(Me.videoPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inpZdroj As TextBox
    Friend WithEvents btnVyberZdroje As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents inpZacatek As TextBox
    Friend WithEvents inpKonec As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnVyberCile As Button
    Friend WithEvents inpCil As TextBox
    Friend WithEvents inpFormat As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnVyberFFProbe As Button
    Friend WithEvents inpFFProbePath As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnVyberFFMpeg As Button
    Friend WithEvents inpFFMpegPath As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents FFMpegCMD As TextBox
    Friend WithEvents videoStreams As ListView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents videoCodec As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents videoBitRate As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents videoSize As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents videoAspectRatio As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents subtitleCodec As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents audioChannels As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents audioFrequency As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents audioBitRate As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents audioCodec As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnZpet As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents btnSetStart As Button
    Friend WithEvents btnSetEnd As Button
    Friend WithEvents audioStreams As ListView
    Friend WithEvents subtitleStreams As ListView
    Friend WithEvents FFMpegFullInfo As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnShowFFMpegLog As Button
    Friend WithEvents btnFFProbeInfo As Button
    Friend WithEvents videoPlayer As AxAXVLC.AxVLCPlugin2
End Class
