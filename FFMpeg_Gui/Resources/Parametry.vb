Module Parametry
    Public streamInfo As Object

    Public logForm As New FFMpegLogForm

    Public Const FFMpegPath As String = "c:\mkv\ffmpeg.exe"
    Public Const FFProbePath As String = "c:\mkv\ffprobe.exe"
    Public Const FFProbeParam = "-v quiet -print_format json -show_format -show_streams "

    Public Const noChangeText As String = "beze změny"

    Public ReadOnly allowedOutputFormat As String() = {"matroska", "mov", "mp4"}
    Public ReadOnly defaultOutputFormat = 0

    Public ReadOnly allowedVideoCodec As String() = {"copy", "h264_nvenc", "libx264", "libx265", "libxvid", "mpeg4"}
    Public ReadOnly DefaultVideoCodec = 1

    Public ReadOnly allowedVideoBitRate As String() = {noChangeText, "800k", "1200k", "1800k", "2500k", "3200k"}
    Public ReadOnly DefaultVideoBitRate = 4

    Public ReadOnly allowedVideoSize As String() = {noChangeText, "1920", "1280", "1024", "854", "800"}
    Public ReadOnly allowedVideoAspectRatio As String() = {noChangeText, "2.35", "19:10", "16:10", "16:9", "3:2", "4:3"}

    Public ReadOnly allowedAudioCodec As String() = {"copy", "aac", "ac3", "mp2", "libmp3lame"}
    Public ReadOnly DefaultAudioCodec = 1

    Public ReadOnly allowedAudioChannels As String() = {noChangeText, "1", "2", "6"}
    Public ReadOnly allowedAudioFrequency As String() = {noChangeText, "11025", "22050", "44100", "48000", "96000"}

    Public ReadOnly allowedAudioBitRate As String() = {noChangeText, "48k", "64k", "96k", "128k", "160k", "192k", "256k", "384k", "576k"}
    Public ReadOnly DefaultAudioBitRate = 6

    Public ReadOnly allowedSubtitleCodec As String() = {"copy", "ass", "srt"}

End Module
