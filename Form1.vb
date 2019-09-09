Imports System.IO

Public Class frmMain
    Private Sub ClearClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearClipboardToolStripMenuItem.Click
        doClipClear()
    End Sub

    Private Sub niClipClear_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles niClipClear.MouseDoubleClick
        doClipClear()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        niClipClear.Dispose()
        Application.Exit()
    End Sub

    Sub PlaySwishSound()
        Dim RecycleSoundPath As String = Path.GetPathRoot(Environment.SystemDirectory) & "Windows\Media\recycle.wav"
        My.Computer.Audio.Play(RecycleSoundPath, AudioPlayMode.Background)
    End Sub

    Sub doClipClear()
        Try
            Clipboard.Clear()
            PlaySwishSound()
        Catch
            MsgBox("Error clearing clipboard.", vbOKOnly & vbCritical, "ClipClear v0.1")
        End Try
    End Sub
End Class
