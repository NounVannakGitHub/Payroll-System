Public Class HighSchool
    Private _highSchoolName As String
    Private _highSchoolStartYear As String
    Private _highSchoolEndyear As String
    Private _grade As String
    ''test comment
    Public Property HighSchoolName As String
        Get
            Return _highSchoolName
        End Get
        Set(value As String)
            _highSchoolName = value
        End Set
    End Property
    Public Property HighSchoolStartYear As String
        Get
            Return _highSchoolStartYear
        End Get
        Set(value As String)
            _highSchoolStartYear = value
        End Set
    End Property
    Public Property HighSchoolEndYear As String
        Get
            Return _highSchoolEndyear
        End Get
        Set(value As String)
            _highSchoolEndyear = value
        End Set
    End Property
    Public Property Grade As String
        Get
            Return _grade
        End Get
        Set(value As String)
            _grade = value
        End Set
    End Property
End Class
