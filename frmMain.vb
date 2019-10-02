Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.InteropServices

Public Class FrmMain
    Public appVersion As String
    Public RecycleSoundPath As String
    Public DefaultSound As String

    Public Const MOD_ALT As Integer = &H1 'Alt key
    Public Const MOD_CTRL As Integer = &H2 'CTRL key
    Public Const MOD_SHIFT As Integer = &H4 'Shift Key
    Public Const MOD_WIN As Integer = &H8 'WIN key

    Public Const WM_HOTKEY As Integer = &H312

    <DllImport("User32.dll")>
    Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    End Function
    <DllImport("User32.dll")>
    Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer) As Integer
    End Function


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

        'Register Hotkey
        RegisterHotKey(Me.Handle, 100, MOD_ALT + MOD_CTRL, Keys.W)

        'Get the current build version and put it in a clean format
        With My.Application.Info.Version
            appVersion = String.Format(" v{0}.{1}.{2}", .Major, .Minor, .Revision)
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

        'Set Start with Windows flag
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "ClipClear", Nothing) Is Nothing Then
            mnuStartatLogon.Checked = False
        Else
            mnuStartatLogon.Checked = True
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
            frmNotify.Dispose()
            frmNotify.Show()
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

    Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        UnregisterHotKey(Me.Handle, 100)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_HOTKEY Then
            Dim id As IntPtr = m.WParam
            Select Case (id.ToString)
                Case "100"
                    'Hotkey Pressed, Clear Clipboard
                    DoClipClear()
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub CmsClipClear_Opening(sender As Object, e As CancelEventArgs) Handles CmsClipClear.Opening

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub StartAtLogonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuStartatLogon.Click
        'Check if the key is in the regisry, if it is, it starts at logon, so remove the key
        With My.Computer.Registry
            If .GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "ClipClear", Nothing) Is Nothing Then
                'Not present, add it
                .SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "ClipClear", My.Application.Info.DirectoryPath & "\ClipClear.exe")
                mnuStartatLogon.Checked = True
            Else
                'Present, Remove it
                .CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run\", True).DeleteValue("ClipClear")
                mnuStartatLogon.Checked = False
            End If
        End With
    End Sub
End Class
