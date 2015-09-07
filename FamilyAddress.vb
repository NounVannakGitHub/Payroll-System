Public Class FamilyAddress
    Implements IAddress
    Private _home As String
    Private _street As String
    Private _village As String
    Private _group As Integer
    Private _commune As String
    Private _district As String
    Private _city As String

    Public Property City As String Implements IAddress.City
        Get
            Return _city
        End Get
        Set(value As String)
            _city = value
        End Set
    End Property
    Public Property Commune As String Implements IAddress.Commune
        Get
            Return _commune
        End Get
        Set(value As String)
            _commune = value
        End Set
    End Property
    Public Property District As String Implements IAddress.District
        Get
            Return _district
        End Get
        Set(value As String)
            _district = value
        End Set
    End Property

    Public Property Group As Integer Implements IAddress.Group
        Get
            Return _group
        End Get
        Set(value As Integer)
            _group = value
        End Set
    End Property
    Public Property Home As String Implements IAddress.Home
        Get
            Return _home
        End Get
        Set(value As String)
            _home = value
        End Set
    End Property
    Public Property Street As String Implements IAddress.Street
        Get
            Return _street
        End Get
        Set(value As String)
            _street = value
        End Set
    End Property
    Public Property Village As String Implements IAddress.Village
        Get
            Return _village
        End Get
        Set(value As String)
            _village = value
        End Set
    End Property
End Class
