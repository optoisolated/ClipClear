<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.niClipClear = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsClipClear = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsClipClear.SuspendLayout()
        Me.SuspendLayout()
        '
        'niClipClear
        '
        Me.niClipClear.ContextMenuStrip = Me.cmsClipClear
        Me.niClipClear.Icon = CType(resources.GetObject("niClipClear.Icon"), System.Drawing.Icon)
        Me.niClipClear.Text = "ClipClear v0.1"
        Me.niClipClear.Visible = True
        '
        'cmsClipClear
        '
        Me.cmsClipClear.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.cmsClipClear.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearClipboardToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.cmsClipClear.Name = "cmsClipClear"
        Me.cmsClipClear.Size = New System.Drawing.Size(207, 74)
        '
        'ClearClipboardToolStripMenuItem
        '
        Me.ClearClipboardToolStripMenuItem.Name = "ClearClipboardToolStripMenuItem"
        Me.ClearClipboardToolStripMenuItem.Size = New System.Drawing.Size(206, 32)
        Me.ClearClipboardToolStripMenuItem.Text = "Clear Clipboard"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(203, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(206, 32)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 251)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.ShowInTaskbar = False
        Me.Text = "ClipClear"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.cmsClipClear.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents niClipClear As NotifyIcon
    Friend WithEvents cmsClipClear As ContextMenuStrip
    Friend WithEvents ClearClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
