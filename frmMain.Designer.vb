<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.NiClipClear = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CmsClipClear = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiUseDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectCustomSoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EnableHotkeyCTRLALTWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeHotkeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFSound = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuStartatLogon = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmsClipClear.SuspendLayout()
        Me.SuspendLayout()
        '
        'NiClipClear
        '
        Me.NiClipClear.ContextMenuStrip = Me.CmsClipClear
        Me.NiClipClear.Icon = CType(resources.GetObject("NiClipClear.Icon"), System.Drawing.Icon)
        Me.NiClipClear.Text = "ClipClear v0.1"
        Me.NiClipClear.Visible = True
        '
        'CmsClipClear
        '
        Me.CmsClipClear.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CmsClipClear.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearClipboardToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.CmsClipClear.Name = "cmsClipClear"
        Me.CmsClipClear.Size = New System.Drawing.Size(181, 104)
        '
        'ClearClipboardToolStripMenuItem
        '
        Me.ClearClipboardToolStripMenuItem.Name = "ClearClipboardToolStripMenuItem"
        Me.ClearClipboardToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearClipboardToolStripMenuItem.Text = "Clear Clipboard"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoundToolStripMenuItem, Me.tsmiUseDefault, Me.ToolStripSeparator2, Me.SelectCustomSoundToolStripMenuItem, Me.ToolStripMenuItem3, Me.EnableHotkeyCTRLALTWToolStripMenuItem, Me.ChangeHotkeyToolStripMenuItem, Me.ToolStripMenuItem4, Me.mnuStartatLogon})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem2.Text = "Options"
        '
        'SoundToolStripMenuItem
        '
        Me.SoundToolStripMenuItem.Name = "SoundToolStripMenuItem"
        Me.SoundToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.SoundToolStripMenuItem.Text = "Sound Enabled"
        '
        'tsmiUseDefault
        '
        Me.tsmiUseDefault.Name = "tsmiUseDefault"
        Me.tsmiUseDefault.Size = New System.Drawing.Size(234, 22)
        Me.tsmiUseDefault.Text = "Use Default Sound"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(231, 6)
        '
        'SelectCustomSoundToolStripMenuItem
        '
        Me.SelectCustomSoundToolStripMenuItem.Name = "SelectCustomSoundToolStripMenuItem"
        Me.SelectCustomSoundToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.SelectCustomSoundToolStripMenuItem.Text = "Change Sound..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(231, 6)
        '
        'EnableHotkeyCTRLALTWToolStripMenuItem
        '
        Me.EnableHotkeyCTRLALTWToolStripMenuItem.Checked = True
        Me.EnableHotkeyCTRLALTWToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnableHotkeyCTRLALTWToolStripMenuItem.Enabled = False
        Me.EnableHotkeyCTRLALTWToolStripMenuItem.Name = "EnableHotkeyCTRLALTWToolStripMenuItem"
        Me.EnableHotkeyCTRLALTWToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.EnableHotkeyCTRLALTWToolStripMenuItem.Text = "Enable Hotkey (CTRL+ALT+W)"
        '
        'ChangeHotkeyToolStripMenuItem
        '
        Me.ChangeHotkeyToolStripMenuItem.Enabled = False
        Me.ChangeHotkeyToolStripMenuItem.Name = "ChangeHotkeyToolStripMenuItem"
        Me.ChangeHotkeyToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ChangeHotkeyToolStripMenuItem.Text = "Change Hotkey"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OFSound
        '
        Me.OFSound.AddExtension = False
        Me.OFSound.Title = "Select Sound File"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(231, 6)
        '
        'mnuStartatLogon
        '
        Me.mnuStartatLogon.Name = "mnuStartatLogon"
        Me.mnuStartatLogon.Size = New System.Drawing.Size(234, 22)
        Me.mnuStartatLogon.Text = "Start at Logon"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 163)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.ShowInTaskbar = False
        Me.Text = "ClipClear"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.CmsClipClear.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NiClipClear As NotifyIcon
    Friend WithEvents CmsClipClear As ContextMenuStrip
    Friend WithEvents ClearClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SoundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectCustomSoundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents OFSound As OpenFileDialog
    Friend WithEvents tsmiUseDefault As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents EnableHotkeyCTRLALTWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeHotkeyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents mnuStartatLogon As ToolStripMenuItem
End Class
