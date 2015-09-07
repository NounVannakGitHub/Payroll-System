Public Class ContactSpousesImpl
    Implements IContact
    Private _homeMobile As String
    Private _personalMobile As String
    Private _email As String
    Private _facebook As String
    Private _line As String
    Public Property Email As String Implements IContact.Email
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
    Public Property Facebook As String Implements IContact.Facebook
        Get
            Return _facebook
        End Get
        Set(value As String)
            _facebook = value
        End Set
    End Property
    Public Property HomeMobile As String Implements IContact.HomeMobile
        Get
            Return _homeMobile
        End Get
        Set(value As String)
            _homeMobile = value
        End Set
    End Property
    Public Property Line As String Implements IContact.Line
        Get
            Return _line
        End Get
        Set(value As String)
            _line = value
        End Set
    End Property
    Public Property PersonalMobile As String Implements IContact.PersonalMobile
        Get
            Return _personalMobile
        End Get
        Set(value As String)
            _personalMobile = value
        End Set
    End Property
End Class
