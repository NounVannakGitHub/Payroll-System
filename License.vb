<System.Serializable()>
Public Class License
    Private _licenseName As String
    Private _licenseKey As String
    Private _licenseDate As String

    Public Property LicenseName As String
        Get
            Return _licenseName
        End Get
        Set(value As String)
            _licenseName = value
        End Set
    End Property

    Public Property LicenseKey As String
        Get
            Return _licenseKey
        End Get
        Set(value As String)
            _licenseKey = value
        End Set
    End Property
    Public Property Token As String
        Get
            Return _licenseDate
        End Get
        Set(value As String)
            _licenseDate = value
        End Set
    End Property
End Class
