Imports System.IO

Public Class FrmMain
    Public appVersion As String
    Public RecycleSoundPath As String
    Public DefaultSound As String

    Private Sub ClearClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearClipboardToolStripMenuItem.Click
        'Chose the Clear Clipboard menu item, lear the Clipboard
        DoClipClear()
    End Sub

    Private Sub niClipClear_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NiClipClear.MouseDoubleClick
        'Double click on the NotifyIcon... Clear the Clipboard
        DoClipClear()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False

        'Get the current build version and put it in a clean format
        With My.Application.Info.Version
            appVersion = String.Format(" v{0}.{1}.{2}", .Major, .Minor, .Build)
        End With

        'Set up the text captions
        Me.Text = My.Settings.AppFriendlyName + appVersion
        NiClipClear.Text = My.Settings.AppFriendlyName + appVersion
        SoundToolStripMenuItem.Checked = My.Settings.ClearSoundEnabled

        'Prep the Open Dialog Box
        OFSound.Filter = "Wave files (*.wav)|*.wav|MP3 files (*.mp3)|*.mp3"
        OFSound.InitialDirectory = Path.GetPathRoot(Environment.SystemDirectory) & "Windows\Media\"

        'Init Sound Info
        DefaultSound = Path.GetPathRoot(Environment.SystemDirectory) & "Windows\Media\recycle.wav"
        If My.Settings.AltSoundPath = "" Then
            RecycleSoundPath = DefaultSound
            tsmiUseDefault.Enabled = False
        Else
            RecycleSoundPath = My.Settings.AltSoundPath
            tsmiUseDefault.Enabled = True
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'We're done, lets exit cleanly.
        NiClipClear.Dispose()
        Close()
    End Sub

    Sub PlaySwishSound()
        'Play a background sound to advise that clipboard has been emptied
        My.Computer.Audio.Play(RecycleSoundPath, AudioPlayMode.Background)
    End Sub

    Sub DoClipClear()
        Try
            'Try the clipboard clear. If it works, play the sound (if its enabled)
            Clipboard.Clear()
            If My.Settings.ClearSoundEnabled Then PlaySwishSound()
        Catch
            'This is unlikely to ever be called, but just in case... 
            MsgBox("Error clearing clipboard.", vbOKOnly & vbCritical, My.Settings.AppFriendlyName + appVersion)
        End Try
    End Sub

    Private Sub SoundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoundToolStripMenuItem.Click
        My.Settings.ClearSoundEnabled = Not (My.Settings.ClearSoundEnabled)
        My.Settings.Save()
        SoundToolStripMenuItem.Checked = My.Settings.ClearSoundEnabled
    End Sub

    Private Sub SelectCustomSoundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectCustomSoundToolStripMenuItem.Click
        If OFSound.ShowDialog <> DialogResult.Cancel Then
            'Cancel not pressed, lets set up the new custom sound.
            My.Settings.AltSoundPath = OFSound.FileName
            My.Settings.Save()
            RecycleSoundPath = OFSound.FileName
            tsmiUseDefault.Enabled = True
        End If
    End Sub

    Private Sub TsmiUseDefault_Click(sender As Object, e As EventArgs) Handles tsmiUseDefault.Click
        'Revert back to the Default Sound
        tsmiUseDefault.Enabled = False
        My.Settings.AltSoundPath = ""
        RecycleSoundPath = DefaultSound
        My.Settings.Save()
    End Sub
End Class
