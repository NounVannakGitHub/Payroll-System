Public Class Employee
    Private _employeeId As String
    Private _firstName As String
    Private _lastName As String
    Private _latinFullName As String
    Private _gender As String
    Private _age As String
    Private _personalStatus As String
    Private _religion As String
    Private _hireDate As String
    Private _photo As String
    Private _address As EmployeeAddress
    Private _dob As String
    Private _placeOfBirth As PlaceOfBirth
    Private _education As Education
    Private _family As Family
    Private _position As Position
    Private _contact As Contact
    Private _workInfomation As WorkInformation
    Private _phone As String
    Private _idCard As String

    Public Property WorkInformation As WorkInformation
        Get
            Return _workInfomation
        End Get
        Set(value As WorkInformation)
            _workInfomation = value
        End Set
    End Property

    Public Property Phone As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property

    Public Property IDCard As String
        Get
            Return _idCard
        End Get
        Set(value As String)
            _idCard = value
        End Set
    End Property

    Sub New(employeeID As String, lastName As String, firstName As String, latinName As String, gender As String, age As String, nationality As String, dob As String, personalStatus As String, phone As String, peopelCard As String, photo As String)
        _employeeId = employeeID
        _lastName = lastName
        _firstName = firstName
        _latinFullName = latinName
        _gender = gender
        _age = age
        _religion = nationality
        _dob = dob
        _personalStatus = personalStatus
        _phone = phone
        _idCard = peopelCard
        _photo = photo
    End Sub

    Public Overrides Function ToString() As String
        Return "LastName=N'" & _lastName & "',FirstName=N'" & _firstName & "',LatinName='" & _latinFullName & "',Gender=N'" & _gender & "',Age='" & _age & "',Nationality=N'" & _religion & "',DOB='" & _dob & "',PersonalStatus=N'" & _personalStatus & "',Phone='" & _phone & "',PeopleCard='" & _idCard & "',Photo='" & _photo & "'"
    End Function

    Public Property FullName As String
        Get
            Return _latinFullName
        End Get
        Set(value As String)
            _latinFullName = value
        End Set
    End Property
    Public Property EmployeeId As String
        Get
            Return _employeeId
        End Get
        Set(value As String)
            _employeeId = value
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
    Public Property Gender As String
        Get
            Return _gender
        End Get
        Set(value As String)
            _gender = value
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
    Public Property PersonalStatus As String
        Get
            Return _personalStatus
        End Get
        Set(value As String)
            _personalStatus = value
        End Set
    End Property
    Public Property Nationality As String
        Get
            Return _religion
        End Get
        Set(value As String)
            _religion = value
        End Set
    End Property
    Public Property HireDate As String
        Get
            Return _hireDate
        End Get
        Set(value As String)
            _hireDate = value
        End Set
    End Property
    Public Property Photo As String
        Get
            Return _photo
        End Get
        Set(value As String)
            _photo = value
        End Set
    End Property
    Public Property DOB As String
        Get
            Return _dob
        End Get
        Set(value As String)
            _dob = value
        End Set
    End Property
    Public Property PlaceOfBirth As PlaceOfBirth
        Get
            Return _placeOfBirth
        End Get
        Set(value As PlaceOfBirth)
            _placeOfBirth = value
        End Set
    End Property
    Public Property Education As Education
        Get
            Return _education
        End Get
        Set(value As Education)
            _education = value
        End Set
    End Property
    Public Property Family As Family
        Get
            Return _family
        End Get
        Set(value As Family)
            _family = value
        End Set
    End Property
    Public Property Position As Position
        Get
            Return _position
        End Get
        Set(value As Position)
            _position = value
        End Set
    End Property
    Public Property Address As EmployeeAddress
        Get
            Return _address
        End Get
        Set(value As EmployeeAddress)
            _address = value
        End Set
    End Property
    Public Property Contact As Contact
        Get
            Return _contact
        End Get
        Set(value As Contact)
            _contact = value
        End Set
    End Property
End Class
