Module BOT

    Public LoginURL As String = "https://www.delugerpg.com/login"
    Public BattleTrainerURL As String = "https://www.delugerpg.com/battle/trainer/"

    Private Sub Pause(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Public Sub WaitIfBrowserIsBusy()

        Do While MnFrm.WebBrowserView.ReadyState <> WebBrowserReadyState.Interactive
            Application.DoEvents()
        Loop

    End Sub

    Public Sub ModeHandler()

        If MnFrm.ComboBoxMode.SelectedIndex = 0 Then
            LogInToSite()
            ModeBattleTrainer()
        End If
    End Sub

    Public Sub LogInToSite()

        MnFrm.WebBrowserView.Navigate(LoginURL)

        Pause(2)


        MnFrm.WebBrowserView.Document.GetElementById("username").SetAttribute("value", GetString(config_file, "User", "UserName", ""))
        MnFrm.WebBrowserView.Document.GetElementById("password").SetAttribute("value", GetString(config_file, "User", "PassWord", ""))

        MnFrm.WebBrowserView.Document.GetElementById("btn-login").InvokeMember("click")

        Pause(4)


    End Sub

    Public Sub ModeBattleTrainer()

        While MnFrm.ButtonStop.Enabled = True

            On Error GoTo Errorlabel

            Dim elements As HtmlElementCollection

            MnFrm.WebBrowserView.Navigate(BattleTrainerURL & GetString(config_file, "TrainerBattle", "ID", "5007"))

            Pause(GetString(config_file, "TrainerBattle", "PauseSeconds", "2"))

            'Selects Pokemon

TrainerSelect: elements = MnFrm.WebBrowserView.Document.GetElementsByTagName("input")
            For Each pElem As HtmlElement In elements

                If (pElem.GetAttribute("value").Equals(GetString(config_file, "TrainerBattle", "Pokemon", "1"))) Then
                    pElem.InvokeMember("click")
                    Exit For
                End If

            Next

            Pause(GetString(config_file, "TrainerBattle", "PauseSeconds", "2"))

            'clicks start battle
            elements = MnFrm.WebBrowserView.Document.GetElementsByTagName("input")
            For Each pElem As HtmlElement In elements

                If (pElem.GetAttribute("value").Contains("Start Battle")) Or (pElem.GetAttribute("value").Contains("Continue")) Then
                    pElem.InvokeMember("click")
                    Exit For
                End If

            Next

            Pause(GetString(config_file, "TrainerBattle", "PauseSeconds", "2"))

            'Selects Attack

TrainerAttack: MnFrm.WebBrowserView.Document.GetElementById("attkopt" & GetString(config_file, "TrainerBattle", "Attack", "1")).InvokeMember("click")

            Pause(GetString(config_file, "TrainerBattle", "PauseSeconds", "2"))


            'Attacks

            elements = MnFrm.WebBrowserView.Document.GetElementsByTagName("input")
            For Each pElem As HtmlElement In elements

                If (pElem.GetAttribute("value").Contains("Attack")) Then
                    pElem.InvokeMember("click")
                    Exit For
                End If

            Next

            Pause(GetString(config_file, "TrainerBattle", "PauseSeconds", "2"))


            'Continue Button

            elements = MnFrm.WebBrowserView.Document.GetElementsByTagName("input")
                For Each pElem As HtmlElement In elements

                    If (pElem.GetAttribute("value").Contains("Continue")) Then
                    pElem.InvokeMember("click")
                    Pause(GetString(config_file, "TrainerBattle", "PauseSeconds", "2"))
                End If

                Next


            WaitIfBrowserIsBusy()

                If MnFrm.WebBrowserView.DocumentText.Contains("Congratulations! You defeated") Then
                    Continue While
                Else

                GoTo TrainerSelect

            End If




        End While
Errorlabel:
        MsgBox("Battle Mode had an error!")
        Exit Sub
    End Sub

End Module
