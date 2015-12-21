Public Class Spouses
    Implements IAddress
    Private _spousesNo As String
    Private _spousesTotal As String
    Private _spousesLastName As String
    Private _spousesFirstName As String
    Private _spousesGender As String
    Private _spousesAge As String
    Private _spousesOccupation As String
    Private _employeeID As String
    Private _home As String
    Private _street As String
    Private _village As String
    Private _group As Integer
    Private _commune As String
    Private _district As String
    Private _city As String
    Private _phone As String

    Sub New(employeeID As String, lastName As String, firstName As String, gender As String, age As String, job As String, child As String, childTotal As String, phone As String, home As String, street As String, city As String, district As String, commune As String, village As String)
        _employeeID = employeeID
        _spousesLastName = lastName
        _spousesFirstName = firstName
        _spousesGender = gender
        _spousesAge = age
        _spousesOccupation = job
        _spousesNo = child
        _spousesTotal = childTotal
        _home = home
        _street = street
        _city = city
        _commune = commune
        _district = district
        _village = village
        _phone = phone
    End Sub

    Public Overrides Function ToString() As String
        Return "LastName=N'" & _spousesLastName & "',FirstName=N'" & _spousesFirstName & "',Gender=N'" & _spousesGender & "',Age='" & _spousesAge & "',Job='" & _spousesOccupation & "',Child=N'" & _spousesNo & "',ChildTotal='" & _spousesTotal & "',Phone='" & _phone & "',Home=N'" & _home & "',Street=N'" & _street & "',City=N'" & _city & "',District=N'" & _district & "',Commune=N'" & _commune & "',Village=N'" & _village & "'"
    End Function

    Public Property Phone As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property

    Public Property EmployeeID As String Implements IAddress.EmployeeID
        Get
            Return _employeeID
        End Get
        Set(value As String)
            _employeeID = value
        End Set
    End Property

    Public Property Child As String
        Get
            Return _spousesNo
        End Get
        Set(value As String)
            _spousesNo = value
        End Set
    End Property
    Public Property SpousesTotal As String
        Get
            Return _spousesTotal
        End Get
        Set(value As String)
            _spousesTotal = value
        End Set
    End Property
    Public Property SpousesLastName As String
        Get
            Return _spousesLastName
        End Get
        Set(value As String)
            _spousesLastName = value
        End Set
    End Property
    Public Property SpousesFirstName As String
        Get
            Return _spousesFirstName
        End Get
        Set(value As String)
            _spousesFirstName = value
        End Set
    End Property
    Public Property SpousesGender As String
        Get
            Return _spousesGender
        End Get
        Set(value As String)
            _spousesGender = value
        End Set
    End Property
    Public Property SpousesAge As String
        Get
            Return _spousesAge
        End Get
        Set(value As String)
            _spousesAge = value
        End Set
    End Property
    Public Property SpousesOccupation As String
        Get
            Return _spousesOccupation
        End Get
        Set(value As String)
            _spousesOccupation = value
        End Set
    End Property

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
