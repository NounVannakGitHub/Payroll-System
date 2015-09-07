Public Class Bachelor
    Private _bachelorId As String
    Private _bachelorMajor As String
    Private _bachelorStartYear As String
    Private _bachelorEndYear As String
    Private _gpa As Double
    Private _university As String
    Sub New()

    End Sub
    Sub New(ByVal Id As Integer, ByVal Major As String, ByVal StartYear As String, ByVal EndYear As String, ByVal GPA As Double, ByVal University As String)
        _bachelorEndYear = EndYear
        _bachelorId = Id
        _bachelorMajor = Major
        _bachelorStartYear = StartYear
        _gpa = GPA
        _university = University
    End Sub
    Public Property BachelorId As String
        Get
            Return _bachelorId
        End Get
        Set(value As String)
            _bachelorId = value
        End Set
    End Property
    Public Property BachelorMajor As String
        Get
            Return _bachelorMajor
        End Get
        Set(value As String)
            _bachelorMajor = value
        End Set
    End Property
    Public Property BachelorStartYear As String
        Get
            Return _bachelorStartYear
        End Get
        Set(value As String)
            _bachelorStartYear = value
        End Set
    End Property
    Public Property BachelorEndYear As String
        Get
            Return _bachelorEndYear
        End Get
        Set(value As String)
            _bachelorEndYear = value
        End Set
    End Property
    Public Property GPA As Double
        Get
            Return _gpa
        End Get
        Set(value As Double)
            _gpa = value
        End Set
    End Property
    Public Property University As String
        Get
            Return _university
        End Get
        Set(value As String)
            _university = value
        End Set
    End Property
End Class
