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

    Sub LoadServer(ByVal comboBox As ComboBox)
        Dim Server As String = String.Empty
        Dim instance As Sql.SqlDataSourceEnumerator = Sql.SqlDataSourceEnumerator.Instance
        Dim table As System.Data.DataTable = instance.GetDataSources()
        For Each row As System.Data.DataRow In table.Rows
            Server = String.Empty
            Server = row("ServerName")
            If row("InstanceName").ToString.Length > 0 Then
                Server = Server & "\" & row("InstanceName")
            End If
            comboBox.Items.Add(Server)
        Next
        comboBox.SelectedIndex = comboBox.FindStringExact(Environment.MachineName)
    End Sub

    Sub LoadDatabase(ByVal server As String, ByVal comboBox As ComboBox)
        Dim con As New SqlClient.SqlConnection("Data Source=" & server & ";Integrated Security=True")
        con.Open()
        Dim cmd As New SqlClient.SqlCommand("sp_databases", con)
        cmd.CommandType = CommandType.StoredProcedure
        Dim read As SqlClient.SqlDataReader = cmd.ExecuteReader()
        While (read.Read())
            comboBox.Items.Add(read("DATABASE_NAME"))
        End While
    End Sub

    Sub ShowPassword(ByVal checkBox As CheckBox, ByVal textBox As TextBox)
        If checkBox.Checked = True Then
            textBox.UseSystemPasswordChar = False
        Else
            textBox.UseSystemPasswordChar = True
        End If
    End Sub

    Sub SetConnectionString(ByVal serverName As String, ByVal database As String, ByVal username As String, ByVal password As String)
        ''Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password
        My.Settings.MyConnectionString() = "Data Source=" & serverName & ";Initial Catalog=" & database & ";User ID=" & username & ";Password=" & password
    End Sub
End Module
