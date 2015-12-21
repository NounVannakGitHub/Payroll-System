Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Public Class LicenseImpl
    Implements ILicense

    Public Function IsLicensed(ByVal licenseName As String, ByVal licenseKey As String, ByVal token As String) As Boolean Implements ILicense.IsLicensed
        Dim isLicense = False
        If licenseKey.Equals(GetLicense.LicenseKey) And licenseName.Equals(GetLicense.LicenseName) And token.Equals(GetLicense.Token) Then
            isLicense = True
        ElseIf licenseKey.Equals(GetLicense.LicenseKey) Then
            isLicense = True
        Else
            isLicense = False
        End If
        Return isLicense
    End Function

    Public Sub PutLicense(licenseName As String, licenseKey As String, token As String) Implements ILicense.PutLicense
        Dim license As New License
        license.LicenseName = licenseName
        license.LicenseKey = licenseKey
        license.Token = token

        Dim fileStream As FileStream = New FileStream(Application.StartupPath & "/License.bin", FileMode.OpenOrCreate)
        Dim binaryFormat As New BinaryFormatter
        binaryFormat.Serialize(fileStream, license)
        fileStream.Close()
    End Sub

    Public Function GetLicense() As License Implements ILicense.GetLicense
        Dim fileSrc As String = Application.StartupPath & "/License.bin"
        Dim obj As New License
            If FileIO.FileSystem.FileExists(fileSrc) Then
                Dim fileStream As FileStream = New FileStream(fileSrc, FileMode.Open)
                Dim binaryFormat As New BinaryFormatter
            obj = binaryFormat.Deserialize(fileStream)
            fileStream.Close()
        End If
        Return obj
    End Function

    Public Sub Insert(license As License) Implements ILicense.Insert
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = SQLValue.INSERT_LINCENSE & "('" & license.LicenseName & "','" & license.LicenseKey & "','" & license.Token & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Your system are registered !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

End Class