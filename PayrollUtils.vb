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
    Function GetCurrentDateAndTime() As String
        Dim nowDate As DateTime
        Return nowDate.Date.ToString
    End Function

    Function DoSelectPictureBackground(ByVal openFileDialog As OpenFileDialog, ByVal path As String) As String

        openFileDialog.InitialDirectory = Application.StartupPath = path
        openFileDialog.Title = "Select image background"
        openFileDialog.ShowDialog()
        openFileDialog.OpenFile()

        Return ""
    End Function
End Module
