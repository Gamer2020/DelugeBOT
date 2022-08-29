<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrainerBattleSettings
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
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrainerIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PokemonComboBox = New System.Windows.Forms.ComboBox()
        Me.AttackComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PauseTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(15, 135)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(226, 23)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "Save and Close"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Trainer ID:"
        '
        'TrainerIDTextBox
        '
        Me.TrainerIDTextBox.Location = New System.Drawing.Point(103, 18)
        Me.TrainerIDTextBox.Name = "TrainerIDTextBox"
        Me.TrainerIDTextBox.Size = New System.Drawing.Size(138, 20)
        Me.TrainerIDTextBox.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Pokemon:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Attack:"
        '
        'PokemonComboBox
        '
        Me.PokemonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PokemonComboBox.FormattingEnabled = True
        Me.PokemonComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.PokemonComboBox.Location = New System.Drawing.Point(103, 44)
        Me.PokemonComboBox.Name = "PokemonComboBox"
        Me.PokemonComboBox.Size = New System.Drawing.Size(138, 21)
        Me.PokemonComboBox.TabIndex = 10
        '
        'AttackComboBox
        '
        Me.AttackComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AttackComboBox.FormattingEnabled = True
        Me.AttackComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.AttackComboBox.Location = New System.Drawing.Point(103, 73)
        Me.AttackComboBox.Name = "AttackComboBox"
        Me.AttackComboBox.Size = New System.Drawing.Size(138, 21)
        Me.AttackComboBox.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Pause Seconds:"
        '
        'PauseTextBox
        '
        Me.PauseTextBox.Location = New System.Drawing.Point(103, 104)
        Me.PauseTextBox.Name = "PauseTextBox"
        Me.PauseTextBox.Size = New System.Drawing.Size(138, 20)
        Me.PauseTextBox.TabIndex = 13
        '
        'TrainerBattleSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 168)
        Me.Controls.Add(Me.PauseTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AttackComboBox)
        Me.Controls.Add(Me.PokemonComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TrainerIDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "TrainerBattleSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trainer Battle Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TrainerIDTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PokemonComboBox As ComboBox
    Friend WithEvents AttackComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PauseTextBox As TextBox
End Class
