Public Class Parent
    Private _fatherLastName As String
    Private _fatherFirstName As String
    Private _fatherAge As Integer
    Private _motherLastName As String
    Private _motherFirstName As String
    Private _fatherLife As String
    Private _motherLife As String
    Private _motherAge As String
    Private _parentAddress As New FamilyAddress
    Private _parentContact As New ContactParentImpl
    Private _parentStatus As String

    Public Property FatherLastName As String
        Get
            Return _fatherLastName
        End Get
        Set(value As String)
            _fatherLastName = value
        End Set
    End Property
    Public Property FatherFirstName As String
        Get
            Return _fatherFirstName
        End Get
        Set(value As String)
            _fatherFirstName = value
        End Set
    End Property
    Public Property FatherAge As Integer
        Get
            Return _fatherAge
        End Get
        Set(value As Integer)
            _fatherAge = value
        End Set
    End Property
    Public Property FatherLife As String
        Get
            Return _fatherLife
        End Get
        Set(value As String)
            _fatherLife = value
        End Set
    End Property
    Public Property MotherLastName As String
        Get
            Return _motherLastName
        End Get
        Set(value As String)
            _motherLastName = value
        End Set
    End Property
    Public Property MotherFirstName As String
        Get
            Return _motherFirstName
        End Get
        Set(value As String)
            _motherFirstName = value
        End Set
    End Property
    Public Property MotherAge As Integer
        Get
            Return _motherAge
        End Get
        Set(value As Integer)
            _motherAge = value
        End Set
    End Property
    Public Property MotherLife As String
        Get
            Return _motherLife
        End Get
        Set(value As String)
            _motherLife = value
        End Set
    End Property
    Public Property ParentStatus As String
        Get
            Return _parentStatus
        End Get
        Set(value As String)
            _parentStatus = value
        End Set
    End Property
    Public Property Address As FamilyAddress
        Get
            Return _parentAddress
        End Get
        Set(value As FamilyAddress)
            _parentAddress = value
        End Set
    End Property
    Public Property Contact As ContactParentImpl
        Get
            Return _parentContact
        End Get
        Set(value As ContactParentImpl)
            _parentContact = value
        End Set
    End Property
End Class
