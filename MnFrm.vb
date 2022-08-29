Option Strict Off
Option Explicit On

Public Class MnFrm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MnFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not System.IO.File.Exists(config_file) Then
            WriteString(config_file, "User", "UserName", "")
            WriteString(config_file, "User", "PassWord", "")
        End If

    End Sub

    Private Sub OpenConfiginiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenConfiginiToolStripMenuItem.Click
        Process.Start(config_file)
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        UserSettings.Show()
    End Sub
End Class
