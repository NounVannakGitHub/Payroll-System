Public Class PrimarySchool
    Private _primarySchoolName As String
    Private _primarySchoolStartYear As String
    Private _primarySchoolEndYear As String

    Public Property PrimarySchoolName As String
        Get
            Return _primarySchoolName
        End Get
        Set(value As String)
            _primarySchoolName = value
        End Set
    End Property
    Public Property PrimarySchoolStartYear As String
        Get
            Return _primarySchoolStartYear
        End Get
        Set(value As String)
            _primarySchoolStartYear = value
        End Set
    End Property
    Public Property PrimarySchoolEndYear As String
        Get
            Return _primarySchoolEndYear
        End Get
        Set(value As String)
            _primarySchoolEndYear = value
        End Set
    End Property
End Class
