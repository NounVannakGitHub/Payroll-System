Public Interface ILicense

    Sub PutLicense(ByVal licenseName As String, ByVal licenseKey As String, ByVal licenseDate As String)
    Function GetLicense() As List(Of String)
    Function IsLicensed(ByVal licenseName As String, ByVal licenseKey As String) As Boolean
End Interface
