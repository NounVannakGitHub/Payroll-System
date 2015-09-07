Public Class Spouses
    Private _spousesNo As Integer
    Private _spousesTotal As Integer
    Private _spousesLastName As String
    Private _spousesFirstName As String
    Private _spousesGender As String
    Private _spousesChild As New Child
    Private _spousesAge As Integer
    Private _spousesOccupation As String
    Private _spousesAddress As New SpousesAddress
    Private _spousesContact As New ContactSpousesImpl

    Public Property SpousesNo As Integer
        Get
            Return _spousesNo
        End Get
        Set(value As Integer)
            _spousesNo = value
        End Set
    End Property
    Public Property SpousesTotal As Integer
        Get
            Return _spousesTotal
        End Get
        Set(value As Integer)
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
    Public Property SpousesAge As Integer
        Get
            Return _spousesAge
        End Get
        Set(value As Integer)
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
    Public Property Address As SpousesAddress
        Get
            Return _spousesAddress
        End Get
        Set(value As SpousesAddress)
            _spousesAddress = value
        End Set
    End Property
    Public Property Contact As ContactSpousesImpl
        Get
            Return _spousesContact
        End Get
        Set(value As ContactSpousesImpl)
            _spousesContact = value
        End Set
    End Property
    Public Property Child As Child
        Get
            Return _spousesChild
        End Get
        Set(value As Child)
            _spousesChild = value
        End Set
    End Property
End Class
