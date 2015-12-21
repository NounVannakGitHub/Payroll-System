Public Class User
    Private pUserId As String
    Private pEmployeeId As String
    Private pLastName As String
    Private pFirstName As String
    Private pPosition As String
    Private pUserName As String
    Private pPassword As String
    Private pConfirmPassword As String
    Private pPhoto As String

    Sub New(aUserId As String, aEmployeeId As String, aLastName As String, aFirstName As String, aPosition As String, aUserName As String, aPassword As String, aConPassword As String, aPhoto As String)
        pUserId = aUserId
        pEmployeeId = aEmployeeId
        pLastName = aLastName
        pFirstName = aFirstName
        pPosition = aPosition
        pUserName = aUserName
        pPassword = aPassword
        pConfirmPassword = aConPassword
        pPhoto = aPhoto
    End Sub

    Public Property UserID As String
        Get
            Return pUserId
        End Get
        Set(value As String)
            pUserId = value
        End Set
    End Property

    Public Property EmployeeID As String
        Get
            Return pEmployeeId
        End Get
        Set(value As String)
            pEmployeeId = value
        End Set
    End Property
    Public Property LastName As String
        Get
            Return pLastName
        End Get
        Set(value As String)
            pLastName = value
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return pFirstName
        End Get
        Set(value As String)
            pFirstName = value
        End Set
    End Property

    Public Property Position As String
        Get
            Return pPosition
        End Get
        Set(value As String)
            pPosition = value
        End Set
    End Property

    Public Property UserName As String
        Get
            Return pUserName
        End Get
        Set(value As String)
            pUserName = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return pPassword
        End Get
        Set(value As String)
            pPassword = value
        End Set
    End Property
    Public Property ConfirmPassword As String
        Get
            Return pConfirmPassword
        End Get
        Set(value As String)
            pConfirmPassword = value
        End Set
    End Property

    Public Property Photo As String
        Get
            Return pPhoto
        End Get
        Set(value As String)
            pPhoto = value
        End Set
    End Property
End Class
