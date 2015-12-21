Public Class Child
    Private _childId As String
    Private _childTotal As Integer
    Private _childLastName As String
    Private _childFirstName As String
    Private _childAge As String
    Private _childGender As String
    Private _employeeID As String
    Private _address As ChildAddress

    Sub New(employeeID As String, childId As String, lastName As String, firstName As String, age As String, gender As String, address As ChildAddress)
        _childAge = age
        _childFirstName = firstName
        _childGender = gender
        _childId = childId
        _childLastName = lastName
        _address = address
        _employeeID = employeeID
    End Sub

    Public Overrides Function ToString() As String
        Return "LastName=N'" & _childLastName & "',FirstName=N'" & _childFirstName & "',Gender=N'" & _childGender & "',Age='" & _childAge & "','" & _address.ToString & "'"
    End Function

    Public Property EmployeeID As String
        Get
            Return _employeeID
        End Get
        Set(value As String)
            _employeeID = value
        End Set
    End Property

    Public Property ChildId As String
        Get
            Return _childId
        End Get
        Set(value As String)
            _childId = value
        End Set
    End Property

    Public Property ChildTotal As String
        Get
            Return _childTotal
        End Get
        Set(value As String)
            _childTotal = value
        End Set
    End Property

    Public Property ChildLastName As String
        Get
            Return _childLastName
        End Get
        Set(value As String)
            _childLastName = value
        End Set
    End Property

    Public Property ChildFirstName As String
        Get
            Return _childFirstName
        End Get
        Set(value As String)
            _childFirstName = value
        End Set
    End Property

    Public Property ChildAge As String
        Get
            Return _childAge
        End Get
        Set(value As String)
            _childAge = value
        End Set
    End Property

    Public Property ChildGender As String
        Get
            Return _childGender
        End Get
        Set(value As String)
            _childGender = value
        End Set
    End Property

    Public Property Address As ChildAddress
        Get
            Return _address
        End Get
        Set(value As ChildAddress)
            _address = value
        End Set
    End Property
End Class
