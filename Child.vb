Public Class Child
    Private _childId As Integer
    Private _childTotal As Integer
    Private _childLastName As String
    Private _childFirstName As String
    Private _childAge As Integer
    Private _childGender As String
    Private _address As New ChildAddress
    Public Property ChildId As Integer
        Get
            Return _childId
        End Get
        Set(value As Integer)
            _childId = value
        End Set
    End Property
    Public Property ChildTotal As Integer
        Get
            Return _childTotal
        End Get
        Set(value As Integer)
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
    Public Property ChildAge As Integer
        Get
            Return _childAge
        End Get
        Set(value As Integer)
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
