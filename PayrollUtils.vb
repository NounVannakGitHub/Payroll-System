Module PayrollUtils
    Sub SwitchLanguage(ByVal language As String)
        If language.Equals("kh") Then
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages.Item(1)
        ElseIf language.Equals("en") Then
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages.Item(0)
        Else
            MessageBox.Show("Your language don't have in this system.")
        End If
    End Sub
End Module
