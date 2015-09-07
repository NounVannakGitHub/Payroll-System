Public Class SecondarySchool
    Private _secondarySchoolName As String
    Private _secondarySchoolStartYear As String
    Private _secondarySchoolEndYear As String

    Public Property SecondarySchoolName As String
        Get
            Return _secondarySchoolName
        End Get
        Set(value As String)
            _secondarySchoolName = value
        End Set
    End Property
    Public Property SecondarySchoolStartYear As String
        Get
            Return _secondarySchoolStartYear
        End Get
        Set(value As String)
            _secondarySchoolStartYear = value
        End Set
    End Property
    Public Property SecondarySchoolEndYear As String
        Get
            Return _secondarySchoolEndYear
        End Get
        Set(value As String)
            _secondarySchoolEndYear = value
        End Set
    End Property
End Class
