<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MnFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MnFrm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenConfiginiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.WebBrowserView = New System.Windows.Forms.WebBrowser()
        Me.CurURLTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ButtonGo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ComboBoxMode = New System.Windows.Forms.ToolStripComboBox()
        Me.ButtonStart = New System.Windows.Forms.ToolStripButton()
        Me.ButtonStop = New System.Windows.Forms.ToolStripButton()
        Me.PauseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrainerBattleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1077, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenConfiginiToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenConfiginiToolStripMenuItem
        '
        Me.OpenConfiginiToolStripMenuItem.Name = "OpenConfiginiToolStripMenuItem"
        Me.OpenConfiginiToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.OpenConfiginiToolStripMenuItem.Text = "Open config.ini"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(153, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.ToolStripMenuItem2, Me.TrainerBattleToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurURLTextBox, Me.ButtonGo, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ComboBoxMode, Me.ButtonStart, Me.ButtonStop})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1077, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'WebBrowserView
        '
        Me.WebBrowserView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowserView.Location = New System.Drawing.Point(0, 49)
        Me.WebBrowserView.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserView.Name = "WebBrowserView"
        Me.WebBrowserView.ScriptErrorsSuppressed = True
        Me.WebBrowserView.Size = New System.Drawing.Size(1077, 499)
        Me.WebBrowserView.TabIndex = 2
        '
        'CurURLTextBox
        '
        Me.CurURLTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CurURLTextBox.Name = "CurURLTextBox"
        Me.CurURLTextBox.Size = New System.Drawing.Size(300, 25)
        '
        'ButtonGo
        '
        Me.ButtonGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ButtonGo.Image = CType(resources.GetObject("ButtonGo.Image"), System.Drawing.Image)
        Me.ButtonGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonGo.Name = "ButtonGo"
        Me.ButtonGo.Size = New System.Drawing.Size(26, 22)
        Me.ButtonGo.Text = "Go"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripLabel1.Text = "Mode:"
        '
        'ComboBoxMode
        '
        Me.ComboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMode.Items.AddRange(New Object() {"Trainer Battle"})
        Me.ComboBoxMode.Name = "ComboBoxMode"
        Me.ComboBoxMode.Size = New System.Drawing.Size(200, 25)
        '
        'ButtonStart
        '
        Me.ButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ButtonStart.Image = CType(resources.GetObject("ButtonStart.Image"), System.Drawing.Image)
        Me.ButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(35, 22)
        Me.ButtonStart.Text = "Start"
        '
        'ButtonStop
        '
        Me.ButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ButtonStop.Enabled = False
        Me.ButtonStop.Image = CType(resources.GetObject("ButtonStop.Image"), System.Drawing.Image)
        Me.ButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(35, 22)
        Me.ButtonStop.Text = "Stop"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(177, 6)
        '
        'TrainerBattleToolStripMenuItem
        '
        Me.TrainerBattleToolStripMenuItem.Name = "TrainerBattleToolStripMenuItem"
        Me.TrainerBattleToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TrainerBattleToolStripMenuItem.Text = "Trainer Battle"
        '
        'MnFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 548)
        Me.Controls.Add(Me.WebBrowserView)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MnFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deluge Bot"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenConfiginiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents CurURLTextBox As ToolStripTextBox
    Friend WithEvents ButtonGo As ToolStripButton
    Friend WithEvents WebBrowserView As WebBrowser
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ComboBoxMode As ToolStripComboBox
    Friend WithEvents ButtonStart As ToolStripButton
    Friend WithEvents ButtonStop As ToolStripButton
    Friend WithEvents PauseTimer As Timer
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents TrainerBattleToolStripMenuItem As ToolStripMenuItem
End Class
