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
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectCustomSoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OFSound = New System.Windows.Forms.OpenFileDialog()
        Me.tsmiUseDefault = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.CmsClipClear.Size = New System.Drawing.Size(241, 145)
        '
        'ClearClipboardToolStripMenuItem
        '
        Me.ClearClipboardToolStripMenuItem.Name = "ClearClipboardToolStripMenuItem"
        Me.ClearClipboardToolStripMenuItem.Size = New System.Drawing.Size(240, 32)
        Me.ClearClipboardToolStripMenuItem.Text = "Clear Clipboard"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(237, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(240, 32)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoundToolStripMenuItem, Me.tsmiUseDefault, Me.ToolStripSeparator2, Me.SelectCustomSoundToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(240, 32)
        Me.ToolStripMenuItem2.Text = "Options"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(237, 6)
        '
        'SoundToolStripMenuItem
        '
        Me.SoundToolStripMenuItem.Name = "SoundToolStripMenuItem"
        Me.SoundToolStripMenuItem.Size = New System.Drawing.Size(296, 34)
        Me.SoundToolStripMenuItem.Text = "Sound Enabled"
        '
        'SelectCustomSoundToolStripMenuItem
        '
        Me.SelectCustomSoundToolStripMenuItem.Name = "SelectCustomSoundToolStripMenuItem"
        Me.SelectCustomSoundToolStripMenuItem.Size = New System.Drawing.Size(296, 34)
        Me.SelectCustomSoundToolStripMenuItem.Text = "Select Custom Sound..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(293, 6)
        '
        'OFSound
        '
        Me.OFSound.AddExtension = False
        Me.OFSound.Title = "Select Sound File"
        '
        'tsmiUseDefault
        '
        Me.tsmiUseDefault.Name = "tsmiUseDefault"
        Me.tsmiUseDefault.Size = New System.Drawing.Size(296, 34)
        Me.tsmiUseDefault.Text = "Use Default Sound"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 251)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
End Class
