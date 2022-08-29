Public Class TrainerBattleSettings
    Private Sub TrainerBattleSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrainerIDTextBox.Text = GetString(config_file, "TrainerBattle", "ID", "5007")
        PokemonComboBox.SelectedIndex = GetString(config_file, "TrainerBattle", "Pokemon", "1") - 1
        AttackComboBox.SelectedIndex = GetString(config_file, "TrainerBattle", "Attack", "1") - 1
        PauseTextBox.Text = GetString(config_file, "TrainerBattle", "PauseSeconds", "2")
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        WriteString(config_file, "TrainerBattle", "ID", TrainerIDTextBox.Text)
        WriteString(config_file, "TrainerBattle", "Pokemon", PokemonComboBox.SelectedIndex + 1)
        WriteString(config_file, "TrainerBattle", "Attack", AttackComboBox.SelectedIndex + 1)
        WriteString(config_file, "TrainerBattle", "PauseSeconds", PauseTextBox.Text)
        Me.Close()
    End Sub
End Class