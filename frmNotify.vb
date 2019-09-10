Public Class frmNotify
    Private Sub TmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        dialogDispose()
    End Sub

    Private Sub FrmNotify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Show()
            .Left = Screen.PrimaryScreen.WorkingArea.Width - .Width
            .Top = Screen.PrimaryScreen.WorkingArea.Height - .Height
            .Focus()
        End With
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        dialogDispose()
    End Sub

    Sub dialogDispose()
        tmrMain.Enabled = False
        Me.Dispose()
    End Sub

    Private Sub frmNotify_Click(sender As Object, e As EventArgs) Handles Me.Click
        dialogDispose()
    End Sub
End Class