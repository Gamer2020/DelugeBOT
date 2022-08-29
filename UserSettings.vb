Public Class UserSettings
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        WriteString(config_file, "User", "UserName", UserNameTextBox.Text)
        WriteString(config_file, "User", "PassWord", PasswordTextBox.Text)
        Me.Close()
    End Sub

    Private Sub UserSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserNameTextBox.Text = GetString(config_file, "User", "UserName", "")
        PasswordTextBox.Text = GetString(config_file, "User", "PassWord", "")
    End Sub
End Class