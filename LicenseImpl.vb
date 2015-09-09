Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Public Class LicenseImpl
    Implements ILicense

    Public Function IsLicensed(ByVal licenseName As String, ByVal licenseKey As String) As Boolean Implements ILicense.IsLicensed
        Dim isLicense = False
        If licenseKey.Equals(GetLicense.LicenseKey) And licenseName.Equals(GetLicense.LicenseName) Then
            isLicense = True
        ElseIf licenseKey.Equals(GetLicense.LicenseKey) Then
            isLicense = True
        Else
            isLicense = False
        End If
        Return isLicense
    End Function

    Public Sub PutLicense(licenseName As String, licenseKey As String, licenseDate As String) Implements ILicense.PutLicense
        Dim license As New License
        license.LicenseName = licenseName
        license.LicenseKey = licenseKey
        license.LicenseDate = licenseDate

        Dim fileStream As FileStream = New FileStream(Application.StartupPath & "License.bin", FileMode.OpenOrCreate)
        Dim binaryFormat As New BinaryFormatter
        binaryFormat.Serialize(fileStream, license)
        fileStream.Close()
    End Sub

    Public Function GetLicense() As License Implements ILicense.GetLicense
        Dim fileSrc As String = Application.StartupPath & "License.bin"
        Dim obj As New License
        If FileIO.FileSystem.FileExists(fileSrc) Then
            Dim fileStream As FileStream = New FileStream(fileSrc, FileMode.Open)
            Dim binaryFormat As New BinaryFormatter
            obj = binaryFormat.Deserialize(fileStream)
        End If
        Return obj
    End Function
End Class