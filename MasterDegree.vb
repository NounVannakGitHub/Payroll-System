Public Class MasterDegree
    Private _masterId As Integer
    Private _masterMajor As String
    Private _masterStartYear As String
    Private _masterEndYear As String
    Private _gpa As Double
    Private _university As String

    Public Property MasterId As Integer
        Get
            Return _masterId
        End Get
        Set(value As Integer)
            _masterId = value
        End Set
    End Property
    Public Property MasterMajor As String
        Get
            Return _masterMajor
        End Get
        Set(value As String)
            _masterMajor = value
        End Set
    End Property
    Public Property MasterStartYear As String
        Get
            Return _masterStartYear
        End Get
        Set(value As String)
            _masterStartYear = value
        End Set
    End Property
    Public Property MasterEndYear As String
        Get
            Return _masterEndYear
        End Get
        Set(value As String)
            _masterEndYear = value
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
