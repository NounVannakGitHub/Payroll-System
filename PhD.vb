Public Class PhD
    Private _phdId As Integer
    Private _phdMajor As String
    Private _phdStartYear As String
    Private _phdEndYear As String
    Private _university As String

    Public Property PhDId As Integer
        Get
            Return _phdId
        End Get
        Set(value As Integer)
            _phdId = value
        End Set
    End Property
    Public Property PhDMajor As String
        Get
            Return _phdMajor
        End Get
        Set(value As String)
            _phdMajor = value
        End Set
    End Property
    Public Property PhDStartYear As String
        Get
            Return _phdStartYear
        End Get
        Set(value As String)
            _phdStartYear = value
        End Set
    End Property
    Public Property PhDEndYear As String
        Get
            Return _phdEndYear
        End Get
        Set(value As String)
            _phdEndYear = value
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
