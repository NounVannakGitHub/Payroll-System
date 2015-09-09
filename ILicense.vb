Public Interface ILicense

    Sub PutLicense(ByVal licenseName As String, ByVal licenseKey As String, ByVal licenseDate As String)
    Function GetLicense() As License
    Function IsLicensed(ByVal licenseName As String, ByVal licenseKey As String) As Boolean
End Interface
