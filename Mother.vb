Public Class Mother
    Implements IAddress
    Private _employeeID As String
    Private _city As String
    Private _commune As String
    Private _district As String
    Private _home As String
    Private _street As String
    Private _village As String
    Private _firstName As String
    Private _lastName As String
    Private _age As String
    Private _lifeStatus As String
    Private _job As String
    Private _phone As String
    Private _groub As String

    Sub New(employeeID As String, lastName As String, firstName As String, age As String, life As String, job As String, phone As String, home As String, street As String, city As String, district As String, commune As String, village As String)
        _employeeID = employeeID
        _lastName = lastName
        _firstName = firstName
        _age = age
        _lifeStatus = life
        _job = job
        _phone = phone
        _home = home
        _street = street
        _city = city
        _district = district
        _commune = commune
        _village = village
    End Sub

    Public Overrides Function ToString() As String
        Return "LastName=N'" & _lastName & "',FirstName=N'" & _firstName & "',Age='" & _age & "',LifeStatus=N'" & _lifeStatus & "',Job='" & _job & "',Phone='" & _phone & "',Home=N'" & _home & "',Street=N'" & _street & "',City=N'" & _city & "',District=N'" & _district & "',Commune=N'" & _commune & "',Village=N'" & _village & "'"
    End Function


    Public Property Phone As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property

    Public Property LifeStatus As String
        Get
            Return _lifeStatus
        End Get
        Set(value As String)
            _lifeStatus = value
        End Set
    End Property

    Public Property Age As String
        Get
            Return _age
        End Get
        Set(value As String)
            _age = value
        End Set
    End Property

    Public Property Job As String
        Get
            Return _job
        End Get
        Set(value As String)
            _job = value
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
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

    Public Property EmployeeID As String Implements IAddress.EmployeeID
        Get
            Return _employeeID
        End Get
        Set(value As String)
            _employeeID = value
        End Set
    End Property

    Public Property Group As Integer Implements IAddress.Group
        Get
            Return _groub
        End Get
        Set(value As Integer)
            _groub = value
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
