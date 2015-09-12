Imports System.IO

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

    '' function get current time
    '' return string
    Function GetCurrentDateAndTime() As String
        Dim nowDate As DateTime
        Return nowDate.Date.ToString
    End Function

    '' function select image use Openfiledialog
    '' return string
    Function DoSelectPictureBackground(ByVal openFileDialog As OpenFileDialog) As String
        Dim fileName As String = ""
        With openFileDialog
            .FileName = ""
            .Title = "Choose image file"
            .InitialDirectory = Application.StartupPath
            .Filter = "PNG|*.png|JPEG|*.jpeg|JPG|*.jpg|All|*.*"
        End With
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                fileName = openFileDialog.FileName
            Catch ex As Exception
                MessageBox.Show("DoSelectPictureBackground" & ex.Message)
            End Try
        Else
            fileName = ""
        End If
        Return fileName
    End Function

    Sub SaveBackgroundImage(ByVal path As String, ByVal content As String)
        System.IO.File.WriteAllText(Application.StartupPath & path, content)
    End Sub

    Function LoadBackgroundImage(ByVal path As String) As String
        Dim src As String = ""
        If System.IO.File.Exists(path) Then
            src = System.IO.File.ReadAllText(Application.StartupPath & path)
        Else
            MessageBox.Show("Your path not exits")
        End If
        Return src
    End Function
End Module
