Option Strict Off
Option Explicit On

Public Class MnFrm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MnFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxMode.SelectedIndex = 0

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

    Private Sub ButtonGo_Click(sender As Object, e As EventArgs) Handles ButtonGo.Click
        WebBrowserView.Navigate(CurURLTextBox.Text)
    End Sub

    Private Sub WebBrowserView_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowserView.Navigated
        CurURLTextBox.Text = WebBrowserView.Url.ToString
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        ButtonStart.Enabled = False
        ComboBoxMode.Enabled = False
        CurURLTextBox.Enabled = False
        ButtonGo.Enabled = False
        ButtonStop.Enabled = True
    End Sub

    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        ButtonStart.Enabled = True
        ComboBoxMode.Enabled = True
        CurURLTextBox.Enabled = True
        ButtonGo.Enabled = True
        ButtonStop.Enabled = False
    End Sub
End Class
